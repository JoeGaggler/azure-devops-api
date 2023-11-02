using System.Text;
using System.Text.Json;

namespace Pingmint.AzureDevOps;

public partial class AzdoClient
{
    private readonly String organization;
    private readonly String project;
    private readonly String apikey;
    private readonly UrlHelper urlHelper;
    private readonly HttpClient httpClient;

    public UrlHelper Urls => urlHelper;

    public AzdoClient(String organization, String project, String apikey)
    {
        this.organization = organization;
        this.project = project;
        this.apikey = apikey;
        this.urlHelper = new UrlHelper(organization, project);
        this.httpClient = CreateHttpClient();
    }

    public static HttpClient CreateHttpClient()
    {
        var handler = new HttpClientHandler()
        {
            AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate,
            UseCookies = false,
            AllowAutoRedirect = false,
        };
        return new System.Net.Http.HttpClient(handler, disposeHandler: true);
    }

    private void AddAcceptHeader(HttpRequestMessage message, String mediaType = "application/json", String? apiVersion = null)
    {
        message.Headers.AcceptEncoding.Add(new System.Net.Http.Headers.StringWithQualityHeaderValue("gzip"));

        var acceptHeader = new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(mediaType);
        if (!String.IsNullOrEmpty(apiVersion))
        {
            acceptHeader.Parameters.Add(new System.Net.Http.Headers.NameValueHeaderValue("api-version", apiVersion));
        }
        message.Headers.Accept.Add(acceptHeader);
    }

    private void AddAuthenticationHeader(HttpRequestMessage message)
    {
        var parameter = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("user:" + apikey));
        var header = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", parameter);
        message.Headers.Authorization = header;
    }

    public static T Deserialize<T>(String json, Model.IJsonSerializer<T> serializer)
    {
        var bytes = Encoding.UTF8.GetBytes(json);
        var options = new JsonReaderOptions()
        {
            AllowTrailingCommas = true,
        };
        var reader = new Utf8JsonReader(bytes, options);
        if (!reader.Read()) { throw new InvalidOperationException("Unable to start parsing JSON"); }
        return serializer.Deserialize(ref reader);
    }

    public static String Serialize<T>(T model, Model.IJsonSerializer<T> serializer)
    {
        var options = new JsonWriterOptions()
        {
            Indented = true,
            SkipValidation = false,
        };

        using (var stream = new MemoryStream())
        {
            var writer = new Utf8JsonWriter(stream, options);
            serializer.Serialize(ref writer, model);
            writer.Dispose();
            stream.Flush();
            return Encoding.UTF8.GetString(stream.ToArray());
        }
    }

    private async Task<HttpResponseMessage> GetAsync(Uri url)
    {
        var message = new HttpRequestMessage(HttpMethod.Get, url);
        AddAcceptHeader(message);
        AddAuthenticationHeader(message);

        return await httpClient.SendAsync(message);
    }

    public async Task<String> PostJsonStringAsync(Uri url, String json) => await SendJsonStringAsync(url, json, HttpMethod.Post);

    public async Task<String> PatchJsonStringAsync(Uri url, String payload) => await SendJsonStringAsync(url, payload, HttpMethod.Patch, "application/json-patch+json");

    public async Task<String> SendJsonStringAsync(Uri url, String json, HttpMethod httpMethod, String contentType = "application/json")
    {
        var message = new HttpRequestMessage(httpMethod, url);
        AddAcceptHeader(message);
        AddAuthenticationHeader(message);

        var content = new StringContent(json);
        content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(contentType);
        await content.LoadIntoBufferAsync(); // HACK: VSTS does not accept chunked transfer-encoding
        message.Content = content;

        var response = await httpClient.SendAsync(message);
        return await response.Content.ReadAsStringAsync();
    }    

    public async Task<String> GetStringAsync(Uri uri)
    {
        var response = await GetAsync(uri);
        return await response.Content.ReadAsStringAsync();
    }

    private async Task<TResult> GetterAsync<TResult>(Func<UrlHelper, Uri> urlFunc, Model.IJsonSerializer<TResult> serializer)
    {
        var url = urlFunc(urlHelper);
        var json = await GetStringAsync(url);
        return Deserialize(json, serializer);
    }
}
