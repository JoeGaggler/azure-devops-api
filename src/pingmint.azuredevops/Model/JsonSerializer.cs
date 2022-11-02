#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Pingmint.AzureDevOps.Model;

public partial interface IJsonSerializer<T>
{
	T Deserialize(ref Utf8JsonReader reader);
	void Serialize(ref Utf8JsonWriter writer, T value);
}
public sealed partial class JsonSerializer : IJsonSerializer<Pingmint.AzureDevOps.Model.PipelinesResults>, IJsonSerializer<Pingmint.AzureDevOps.Model.Pipeline>, IJsonSerializer<Pingmint.AzureDevOps.Model.ReferenceLinks>, IJsonSerializer<Pingmint.AzureDevOps.Model.ReferenceLink>
{
	public static readonly IJsonSerializer<PipelinesResults> PipelinesResults = new JsonSerializer();
	public static readonly IJsonSerializer<Pipeline> Pipeline = new JsonSerializer();
	public static readonly IJsonSerializer<ReferenceLinks> ReferenceLinks = new JsonSerializer();
	public static readonly IJsonSerializer<ReferenceLink> ReferenceLink = new JsonSerializer();

	private static JsonTokenType Next(ref Utf8JsonReader reader) => reader.Read() ? reader.TokenType : throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");

	void IJsonSerializer<Pingmint.AzureDevOps.Model.PipelinesResults>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.PipelinesResults value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Count is { } localCount)
		{
			writer.WritePropertyName("count");
			writer.WriteNumberValue(localCount);
		}
		if (value.Value is { } localValue)
		{
			writer.WritePropertyName("value");
			InternalSerializer0.Serialize(ref writer, localValue);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.PipelinesResults IJsonSerializer<Pingmint.AzureDevOps.Model.PipelinesResults>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.PipelinesResults();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("count"))
					{
						obj.Count = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.Number => reader.GetInt32(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Count: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("value"))
					{
						obj.Value = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartArray => InternalSerializer0.Deserialize(ref reader, obj.Value ?? new()),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Value: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return obj;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	void IJsonSerializer<Pingmint.AzureDevOps.Model.Pipeline>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.Pipeline value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Id is { } localId)
		{
			writer.WritePropertyName("id");
			writer.WriteNumberValue(localId);
		}
		if (value.Revision is { } localRevision)
		{
			writer.WritePropertyName("revision");
			writer.WriteNumberValue(localRevision);
		}
		if (value.Name is { } localName)
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(localName);
		}
		if (value.Folder is { } localFolder)
		{
			writer.WritePropertyName("folder");
			writer.WriteStringValue(localFolder);
		}
		if (value.Url is { } localUrl)
		{
			writer.WritePropertyName("url");
			writer.WriteStringValue(localUrl);
		}
		if (value.Links is { } localLinks)
		{
			writer.WritePropertyName("_links");
			ReferenceLinks.Serialize(ref writer, localLinks);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.Pipeline IJsonSerializer<Pingmint.AzureDevOps.Model.Pipeline>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.Pipeline();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("id"))
					{
						obj.Id = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.Number => reader.GetInt32(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Id: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("revision"))
					{
						obj.Revision = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.Number => reader.GetInt32(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Revision: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("name"))
					{
						obj.Name = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Name: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("folder"))
					{
						obj.Folder = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Folder: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("url"))
					{
						obj.Url = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Url: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("_links"))
					{
						obj.Links = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => ReferenceLinks.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Links: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return obj;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	void IJsonSerializer<Pingmint.AzureDevOps.Model.ReferenceLinks>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.ReferenceLinks value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Self is { } localSelf)
		{
			writer.WritePropertyName("self");
			ReferenceLink.Serialize(ref writer, localSelf);
		}
		if (value.Web is { } localWeb)
		{
			writer.WritePropertyName("web");
			ReferenceLink.Serialize(ref writer, localWeb);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.ReferenceLinks IJsonSerializer<Pingmint.AzureDevOps.Model.ReferenceLinks>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.ReferenceLinks();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("self"))
					{
						obj.Self = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => ReferenceLink.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Self: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("web"))
					{
						obj.Web = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => ReferenceLink.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Web: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return obj;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	void IJsonSerializer<Pingmint.AzureDevOps.Model.ReferenceLink>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.ReferenceLink value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Href is { } localHref)
		{
			writer.WritePropertyName("href");
			writer.WriteStringValue(localHref);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.ReferenceLink IJsonSerializer<Pingmint.AzureDevOps.Model.ReferenceLink>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.ReferenceLink();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("href"))
					{
						obj.Href = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Href: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return obj;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	private static class InternalSerializer0
	{
		public static void Serialize<TArray>(ref Utf8JsonWriter writer, TArray array) where TArray : ICollection<Pipeline>
		{
			if (array is null) { writer.WriteNullValue(); return; }
			writer.WriteStartArray();
			foreach (var item in array)
			{
				Pipeline.Serialize(ref writer, item);
			}
			writer.WriteEndArray();
		}

		public static TArray Deserialize<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<Pipeline>
		{
			while (true)
			{
				switch (Next(ref reader))
				{
					case JsonTokenType.Null:
					{
						reader.Skip();
						break;
					}
					case JsonTokenType.StartObject:
					{
						var item = Pipeline.Deserialize(ref reader);
						array.Add(item);
						break;
					}
					case JsonTokenType.EndArray:
					{
						return array;
					}
					default:
					{
						reader.Skip();
						break;
					}
				}
			}
		}
	}
}
public sealed partial class PipelinesResults
{
	public int? Count { get; set; }
	public List<Pipeline>? Value { get; set; }
}
public sealed partial class Pipeline
{
	public int? Id { get; set; }
	public int? Revision { get; set; }
	public String? Name { get; set; }
	public String? Folder { get; set; }
	public String? Url { get; set; }
	public ReferenceLinks? Links { get; set; }
}
public sealed partial class ReferenceLinks
{
	public ReferenceLink? Self { get; set; }
	public ReferenceLink? Web { get; set; }
}
public sealed partial class ReferenceLink
{
	public String? Href { get; set; }
}
