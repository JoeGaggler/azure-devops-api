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
public sealed partial class JsonSerializer : IJsonSerializer<Pingmint.AzureDevOps.Model.GitDiffsResult>, IJsonSerializer<Pingmint.AzureDevOps.Model.GitDiffsResultChange>, IJsonSerializer<Pingmint.AzureDevOps.Model.GitDiffsResultChangeCounts>, IJsonSerializer<Pingmint.AzureDevOps.Model.GitRepositoryResult>, IJsonSerializer<Pingmint.AzureDevOps.Model.TODO_GitRepositoryResult>, IJsonSerializer<Pingmint.AzureDevOps.Model.GitRepositoryResultProject>, IJsonSerializer<Pingmint.AzureDevOps.Model.GitBranchStatsResults>, IJsonSerializer<Pingmint.AzureDevOps.Model.GitBranchStatsResultsCommit>, IJsonSerializer<Pingmint.AzureDevOps.Model.GitBranchStatsResultsCommitPerson>, IJsonSerializer<Pingmint.AzureDevOps.Model.PipelinesResult>, IJsonSerializer<Pingmint.AzureDevOps.Model.PipelinesResultItem>, IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResult>, IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResultPipeline>, IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResultResources>, IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResultResourcesPipelines>, IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResultResourcesPipelinesItem>, IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResultResourcesPipelinesItemReference>, IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResultResourcesRepositories>, IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResultResourcesRepositoriesItem>, IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResultResourcesRepositoriesItemReference>, IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunsResult>, IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunsResultItem>, IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunsResultItemPipeline>, IJsonSerializer<Pingmint.AzureDevOps.Model.TemplateParameters>, IJsonSerializer<Pingmint.AzureDevOps.Model.ReferenceLinks>, IJsonSerializer<Pingmint.AzureDevOps.Model.ReferenceLink>
{
	public static readonly IJsonSerializer<GitDiffsResult> GitDiffsResult = new JsonSerializer();
	public static readonly IJsonSerializer<GitDiffsResultChange> GitDiffsResultChange = new JsonSerializer();
	public static readonly IJsonSerializer<GitDiffsResultChangeCounts> GitDiffsResultChangeCounts = new JsonSerializer();
	public static readonly IJsonSerializer<GitRepositoryResult> GitRepositoryResult = new JsonSerializer();
	public static readonly IJsonSerializer<TODO_GitRepositoryResult> TODO_GitRepositoryResult = new JsonSerializer();
	public static readonly IJsonSerializer<GitRepositoryResultProject> GitRepositoryResultProject = new JsonSerializer();
	public static readonly IJsonSerializer<GitBranchStatsResults> GitBranchStatsResults = new JsonSerializer();
	public static readonly IJsonSerializer<GitBranchStatsResultsCommit> GitBranchStatsResultsCommit = new JsonSerializer();
	public static readonly IJsonSerializer<GitBranchStatsResultsCommitPerson> GitBranchStatsResultsCommitPerson = new JsonSerializer();
	public static readonly IJsonSerializer<PipelinesResult> PipelinesResult = new JsonSerializer();
	public static readonly IJsonSerializer<PipelinesResultItem> PipelinesResultItem = new JsonSerializer();
	public static readonly IJsonSerializer<PipelineRunResult> PipelineRunResult = new JsonSerializer();
	public static readonly IJsonSerializer<PipelineRunResultPipeline> PipelineRunResultPipeline = new JsonSerializer();
	public static readonly IJsonSerializer<PipelineRunResultResources> PipelineRunResultResources = new JsonSerializer();
	public static readonly IJsonSerializer<PipelineRunResultResourcesPipelines> PipelineRunResultResourcesPipelines = new JsonSerializer();
	public static readonly IJsonSerializer<PipelineRunResultResourcesPipelinesItem> PipelineRunResultResourcesPipelinesItem = new JsonSerializer();
	public static readonly IJsonSerializer<PipelineRunResultResourcesPipelinesItemReference> PipelineRunResultResourcesPipelinesItemReference = new JsonSerializer();
	public static readonly IJsonSerializer<PipelineRunResultResourcesRepositories> PipelineRunResultResourcesRepositories = new JsonSerializer();
	public static readonly IJsonSerializer<PipelineRunResultResourcesRepositoriesItem> PipelineRunResultResourcesRepositoriesItem = new JsonSerializer();
	public static readonly IJsonSerializer<PipelineRunResultResourcesRepositoriesItemReference> PipelineRunResultResourcesRepositoriesItemReference = new JsonSerializer();
	public static readonly IJsonSerializer<PipelineRunsResult> PipelineRunsResult = new JsonSerializer();
	public static readonly IJsonSerializer<PipelineRunsResultItem> PipelineRunsResultItem = new JsonSerializer();
	public static readonly IJsonSerializer<PipelineRunsResultItemPipeline> PipelineRunsResultItemPipeline = new JsonSerializer();
	public static readonly IJsonSerializer<TemplateParameters> TemplateParameters = new JsonSerializer();
	public static readonly IJsonSerializer<ReferenceLinks> ReferenceLinks = new JsonSerializer();
	public static readonly IJsonSerializer<ReferenceLink> ReferenceLink = new JsonSerializer();

	private static JsonTokenType Next(ref Utf8JsonReader reader) => reader.Read() ? reader.TokenType : throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");

	void IJsonSerializer<Pingmint.AzureDevOps.Model.GitDiffsResult>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.GitDiffsResult value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.aheadCount is { } localaheadCount)
		{
			writer.WritePropertyName("aheadCount");
			writer.WriteNumberValue(localaheadCount);
		}
		if (value.allChangesIncluded is { } localallChangesIncluded)
		{
			writer.WritePropertyName("allChangesIncluded");
			writer.WriteBooleanValue(localallChangesIncluded);
		}
		if (value.behindCount is { } localbehindCount)
		{
			writer.WritePropertyName("behindCount");
			writer.WriteNumberValue(localbehindCount);
		}
		if (value.changeCounts is { } localchangeCounts)
		{
			writer.WritePropertyName("changeCounts");
			GitDiffsResultChangeCounts.Serialize(ref writer, localchangeCounts);
		}
		if (value.commonCommit is { } localcommonCommit)
		{
			writer.WritePropertyName("commonCommit");
			writer.WriteStringValue(localcommonCommit);
		}
		if (value.changes is { } localchanges)
		{
			writer.WritePropertyName("changes");
			InternalSerializer0.Serialize(ref writer, localchanges);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.GitDiffsResult IJsonSerializer<Pingmint.AzureDevOps.Model.GitDiffsResult>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.GitDiffsResult();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("aheadCount"))
					{
						obj.aheadCount = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.Number => reader.GetInt32(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for aheadCount: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("allChangesIncluded"))
					{
						obj.allChangesIncluded = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.True => reader.GetBoolean(),
							JsonTokenType.False => reader.GetBoolean(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for allChangesIncluded: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("behindCount"))
					{
						obj.behindCount = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.Number => reader.GetInt32(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for behindCount: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("changeCounts"))
					{
						obj.changeCounts = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GitDiffsResultChangeCounts.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for changeCounts: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("commonCommit"))
					{
						obj.commonCommit = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for commonCommit: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("changes"))
					{
						obj.changes = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartArray => InternalSerializer0.Deserialize(ref reader, obj.changes ?? new()),
							var unexpected => throw new InvalidOperationException($"unexpected token type for changes: {unexpected} ")
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.GitDiffsResultChange>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.GitDiffsResultChange value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.TODO is { } localTODO)
		{
			writer.WritePropertyName("TODO");
			writer.WriteStringValue(localTODO);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.GitDiffsResultChange IJsonSerializer<Pingmint.AzureDevOps.Model.GitDiffsResultChange>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.GitDiffsResultChange();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("TODO"))
					{
						obj.TODO = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for TODO: {unexpected} ")
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.GitDiffsResultChangeCounts>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.GitDiffsResultChangeCounts value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Add is { } localAdd)
		{
			writer.WritePropertyName("Add");
			writer.WriteNumberValue(localAdd);
		}
		if (value.Edit is { } localEdit)
		{
			writer.WritePropertyName("Edit");
			writer.WriteNumberValue(localEdit);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.GitDiffsResultChangeCounts IJsonSerializer<Pingmint.AzureDevOps.Model.GitDiffsResultChangeCounts>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.GitDiffsResultChangeCounts();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("Add"))
					{
						obj.Add = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.Number => reader.GetInt32(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Add: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("Edit"))
					{
						obj.Edit = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.Number => reader.GetInt32(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Edit: {unexpected} ")
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.GitRepositoryResult>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.GitRepositoryResult value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Links is { } localLinks)
		{
			writer.WritePropertyName("_links");
			ReferenceLinks.Serialize(ref writer, localLinks);
		}
		if (value.DefaultBranch is { } localDefaultBranch)
		{
			writer.WritePropertyName("defaultBranch");
			writer.WriteStringValue(localDefaultBranch);
		}
		if (value.Id is { } localId)
		{
			writer.WritePropertyName("id");
			writer.WriteStringValue(localId);
		}
		if (value.Name is { } localName)
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(localName);
		}
		if (value.Project is { } localProject)
		{
			writer.WritePropertyName("project");
			GitRepositoryResultProject.Serialize(ref writer, localProject);
		}
		if (value.RemoteUrl is { } localRemoteUrl)
		{
			writer.WritePropertyName("remoteUrl");
			writer.WriteStringValue(localRemoteUrl);
		}
		if (value.Size is { } localSize)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(localSize);
		}
		if (value.sshUrl is { } localsshUrl)
		{
			writer.WritePropertyName("sshUrl");
			writer.WriteStringValue(localsshUrl);
		}
		if (value.Url is { } localUrl)
		{
			writer.WritePropertyName("url");
			writer.WriteStringValue(localUrl);
		}
		if (value.webUrl is { } localwebUrl)
		{
			writer.WritePropertyName("webUrl");
			writer.WriteStringValue(localwebUrl);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.GitRepositoryResult IJsonSerializer<Pingmint.AzureDevOps.Model.GitRepositoryResult>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.GitRepositoryResult();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("_links"))
					{
						obj.Links = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => ReferenceLinks.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Links: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("defaultBranch"))
					{
						obj.DefaultBranch = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for DefaultBranch: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("id"))
					{
						obj.Id = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Id: {unexpected} ")
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
					else if (reader.ValueTextEquals("project"))
					{
						obj.Project = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GitRepositoryResultProject.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Project: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("remoteUrl"))
					{
						obj.RemoteUrl = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for RemoteUrl: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("size"))
					{
						obj.Size = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.Number => reader.GetInt32(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Size: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("sshUrl"))
					{
						obj.sshUrl = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for sshUrl: {unexpected} ")
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
					else if (reader.ValueTextEquals("webUrl"))
					{
						obj.webUrl = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for webUrl: {unexpected} ")
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.TODO_GitRepositoryResult>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.TODO_GitRepositoryResult value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.IsDisabled is { } localIsDisabled)
		{
			writer.WritePropertyName("isDisabled");
			writer.WriteNumberValue(localIsDisabled);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.TODO_GitRepositoryResult IJsonSerializer<Pingmint.AzureDevOps.Model.TODO_GitRepositoryResult>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.TODO_GitRepositoryResult();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("isDisabled"))
					{
						obj.IsDisabled = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.Number => reader.GetInt32(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for IsDisabled: {unexpected} ")
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.GitRepositoryResultProject>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.GitRepositoryResultProject value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.id is { } localid)
		{
			writer.WritePropertyName("id");
			writer.WriteStringValue(localid);
		}
		if (value.name is { } localname)
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(localname);
		}
		if (value.url is { } localurl)
		{
			writer.WritePropertyName("url");
			writer.WriteStringValue(localurl);
		}
		if (value.state is { } localstate)
		{
			writer.WritePropertyName("state");
			writer.WriteStringValue(localstate);
		}
		if (value.revision is { } localrevision)
		{
			writer.WritePropertyName("revision");
			writer.WriteNumberValue(localrevision);
		}
		if (value.visibility is { } localvisibility)
		{
			writer.WritePropertyName("visibility");
			writer.WriteStringValue(localvisibility);
		}
		if (value.lastUpdateTime is { } locallastUpdateTime)
		{
			writer.WritePropertyName("lastUpdateTime");
			writer.WriteStringValue(locallastUpdateTime);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.GitRepositoryResultProject IJsonSerializer<Pingmint.AzureDevOps.Model.GitRepositoryResultProject>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.GitRepositoryResultProject();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("id"))
					{
						obj.id = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for id: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("name"))
					{
						obj.name = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for name: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("url"))
					{
						obj.url = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for url: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("state"))
					{
						obj.state = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for state: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("revision"))
					{
						obj.revision = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.Number => reader.GetInt32(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for revision: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("visibility"))
					{
						obj.visibility = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for visibility: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("lastUpdateTime"))
					{
						obj.lastUpdateTime = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for lastUpdateTime: {unexpected} ")
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.GitBranchStatsResults>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.GitBranchStatsResults value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.aheadCount is { } localaheadCount)
		{
			writer.WritePropertyName("aheadCount");
			writer.WriteNumberValue(localaheadCount);
		}
		if (value.behindCount is { } localbehindCount)
		{
			writer.WritePropertyName("behindCount");
			writer.WriteNumberValue(localbehindCount);
		}
		if (value.commit is { } localcommit)
		{
			writer.WritePropertyName("commit");
			GitBranchStatsResultsCommit.Serialize(ref writer, localcommit);
		}
		if (value.isBaseVersion is { } localisBaseVersion)
		{
			writer.WritePropertyName("isBaseVersion");
			writer.WriteBooleanValue(localisBaseVersion);
		}
		if (value.name is { } localname)
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(localname);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.GitBranchStatsResults IJsonSerializer<Pingmint.AzureDevOps.Model.GitBranchStatsResults>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.GitBranchStatsResults();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("aheadCount"))
					{
						obj.aheadCount = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.Number => reader.GetInt32(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for aheadCount: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("behindCount"))
					{
						obj.behindCount = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.Number => reader.GetInt32(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for behindCount: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("commit"))
					{
						obj.commit = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GitBranchStatsResultsCommit.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for commit: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("isBaseVersion"))
					{
						obj.isBaseVersion = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.True => reader.GetBoolean(),
							JsonTokenType.False => reader.GetBoolean(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for isBaseVersion: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("name"))
					{
						obj.name = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for name: {unexpected} ")
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.GitBranchStatsResultsCommit>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.GitBranchStatsResultsCommit value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.treeId is { } localtreeId)
		{
			writer.WritePropertyName("treeId");
			writer.WriteStringValue(localtreeId);
		}
		if (value.commitId is { } localcommitId)
		{
			writer.WritePropertyName("commitId");
			writer.WriteStringValue(localcommitId);
		}
		if (value.author is { } localauthor)
		{
			writer.WritePropertyName("author");
			GitBranchStatsResultsCommitPerson.Serialize(ref writer, localauthor);
		}
		if (value.committer is { } localcommitter)
		{
			writer.WritePropertyName("committer");
			GitBranchStatsResultsCommitPerson.Serialize(ref writer, localcommitter);
		}
		if (value.comment is { } localcomment)
		{
			writer.WritePropertyName("comment");
			writer.WriteStringValue(localcomment);
		}
		if (value.parents is { } localparents)
		{
			writer.WritePropertyName("parents");
			InternalSerializer1.Serialize(ref writer, localparents);
		}
		if (value.url is { } localurl)
		{
			writer.WritePropertyName("url");
			writer.WriteStringValue(localurl);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.GitBranchStatsResultsCommit IJsonSerializer<Pingmint.AzureDevOps.Model.GitBranchStatsResultsCommit>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.GitBranchStatsResultsCommit();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("treeId"))
					{
						obj.treeId = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for treeId: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("commitId"))
					{
						obj.commitId = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for commitId: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("author"))
					{
						obj.author = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GitBranchStatsResultsCommitPerson.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for author: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("committer"))
					{
						obj.committer = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GitBranchStatsResultsCommitPerson.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for committer: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("comment"))
					{
						obj.comment = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for comment: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("parents"))
					{
						obj.parents = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartArray => InternalSerializer1.Deserialize(ref reader, obj.parents ?? new()),
							var unexpected => throw new InvalidOperationException($"unexpected token type for parents: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("url"))
					{
						obj.url = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for url: {unexpected} ")
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.GitBranchStatsResultsCommitPerson>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.GitBranchStatsResultsCommitPerson value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.name is { } localname)
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(localname);
		}
		if (value.email is { } localemail)
		{
			writer.WritePropertyName("email");
			writer.WriteStringValue(localemail);
		}
		if (value.date is { } localdate)
		{
			writer.WritePropertyName("date");
			writer.WriteStringValue(localdate);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.GitBranchStatsResultsCommitPerson IJsonSerializer<Pingmint.AzureDevOps.Model.GitBranchStatsResultsCommitPerson>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.GitBranchStatsResultsCommitPerson();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("name"))
					{
						obj.name = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for name: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("email"))
					{
						obj.email = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for email: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("date"))
					{
						obj.date = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for date: {unexpected} ")
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.PipelinesResult>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.PipelinesResult value)
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
			InternalSerializer2.Serialize(ref writer, localValue);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.PipelinesResult IJsonSerializer<Pingmint.AzureDevOps.Model.PipelinesResult>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.PipelinesResult();
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
							JsonTokenType.StartArray => InternalSerializer2.Deserialize(ref reader, obj.Value ?? new()),
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.PipelinesResultItem>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.PipelinesResultItem value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Id is { } localId)
		{
			writer.WritePropertyName("id");
			writer.WriteNumberValue(localId);
		}
		if (value.Folder is { } localFolder)
		{
			writer.WritePropertyName("folder");
			writer.WriteStringValue(localFolder);
		}
		if (value.Name is { } localName)
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(localName);
		}
		if (value.Revision is { } localRevision)
		{
			writer.WritePropertyName("revision");
			writer.WriteNumberValue(localRevision);
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

	Pingmint.AzureDevOps.Model.PipelinesResultItem IJsonSerializer<Pingmint.AzureDevOps.Model.PipelinesResultItem>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.PipelinesResultItem();
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResult>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.PipelineRunResult value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Links is { } localLinks)
		{
			writer.WritePropertyName("_links");
			ReferenceLinks.Serialize(ref writer, localLinks);
		}
		if (value.CreatedDate is { } localCreatedDate)
		{
			writer.WritePropertyName("createdDate");
			writer.WriteStringValue(localCreatedDate);
		}
		if (value.FinishedDate is { } localFinishedDate)
		{
			writer.WritePropertyName("finishedDate");
			writer.WriteStringValue(localFinishedDate);
		}
		if (value.Id is { } localId)
		{
			writer.WritePropertyName("id");
			writer.WriteNumberValue(localId);
		}
		if (value.Name is { } localName)
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(localName);
		}
		if (value.Pipeline is { } localPipeline)
		{
			writer.WritePropertyName("pipeline");
			PipelineRunsResultItemPipeline.Serialize(ref writer, localPipeline);
		}
		if (value.State is { } localState)
		{
			writer.WritePropertyName("state");
			writer.WriteStringValue(localState);
		}
		if (value.Result is { } localResult)
		{
			writer.WritePropertyName("result");
			writer.WriteStringValue(localResult);
		}
		if (value.TemplateParameters is { } localTemplateParameters)
		{
			writer.WritePropertyName("templateParameters");
			TemplateParameters.Serialize(ref writer, localTemplateParameters);
		}
		if (value.Url is { } localUrl)
		{
			writer.WritePropertyName("url");
			writer.WriteStringValue(localUrl);
		}
		if (value.Resources is { } localResources)
		{
			writer.WritePropertyName("resources");
			PipelineRunResultResources.Serialize(ref writer, localResources);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.PipelineRunResult IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResult>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.PipelineRunResult();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("_links"))
					{
						obj.Links = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => ReferenceLinks.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Links: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("createdDate"))
					{
						obj.CreatedDate = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for CreatedDate: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("finishedDate"))
					{
						obj.FinishedDate = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for FinishedDate: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("id"))
					{
						obj.Id = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.Number => reader.GetInt32(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Id: {unexpected} ")
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
					else if (reader.ValueTextEquals("pipeline"))
					{
						obj.Pipeline = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => PipelineRunsResultItemPipeline.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Pipeline: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("state"))
					{
						obj.State = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for State: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("result"))
					{
						obj.Result = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Result: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("templateParameters"))
					{
						obj.TemplateParameters = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => TemplateParameters.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for TemplateParameters: {unexpected} ")
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
					else if (reader.ValueTextEquals("resources"))
					{
						obj.Resources = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => PipelineRunResultResources.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Resources: {unexpected} ")
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResultPipeline>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.PipelineRunResultPipeline value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Id is { } localId)
		{
			writer.WritePropertyName("id");
			writer.WriteNumberValue(localId);
		}
		if (value.Folder is { } localFolder)
		{
			writer.WritePropertyName("folder");
			writer.WriteStringValue(localFolder);
		}
		if (value.Name is { } localName)
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(localName);
		}
		if (value.Revision is { } localRevision)
		{
			writer.WritePropertyName("revision");
			writer.WriteNumberValue(localRevision);
		}
		if (value.Url is { } localUrl)
		{
			writer.WritePropertyName("url");
			writer.WriteStringValue(localUrl);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.PipelineRunResultPipeline IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResultPipeline>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.PipelineRunResultPipeline();
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResultResources>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.PipelineRunResultResources value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Repositories is { } localRepositories)
		{
			writer.WritePropertyName("repositories");
			PipelineRunResultResourcesRepositories.Serialize(ref writer, localRepositories);
		}
		if (value.Pipelines is { } localPipelines)
		{
			writer.WritePropertyName("pipelines");
			PipelineRunResultResourcesPipelines.Serialize(ref writer, localPipelines);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.PipelineRunResultResources IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResultResources>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.PipelineRunResultResources();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("repositories"))
					{
						obj.Repositories = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => PipelineRunResultResourcesRepositories.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Repositories: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("pipelines"))
					{
						obj.Pipelines = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => PipelineRunResultResourcesPipelines.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Pipelines: {unexpected} ")
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResultResourcesPipelines>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.PipelineRunResultResourcesPipelines value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.All is { } localAll)
		{
			writer.WritePropertyName("*");
			PipelineRunResultResourcesPipelinesItem.Serialize(ref writer, localAll);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.PipelineRunResultResourcesPipelines IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResultResourcesPipelines>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.PipelineRunResultResourcesPipelines();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("*"))
					{
						obj.All = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => PipelineRunResultResourcesPipelinesItem.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for All: {unexpected} ")
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResultResourcesPipelinesItem>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.PipelineRunResultResourcesPipelinesItem value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Pipeline is { } localPipeline)
		{
			writer.WritePropertyName("pipeline");
			PipelineRunResultResourcesPipelinesItemReference.Serialize(ref writer, localPipeline);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.PipelineRunResultResourcesPipelinesItem IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResultResourcesPipelinesItem>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.PipelineRunResultResourcesPipelinesItem();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("pipeline"))
					{
						obj.Pipeline = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => PipelineRunResultResourcesPipelinesItemReference.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Pipeline: {unexpected} ")
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResultResourcesPipelinesItemReference>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.PipelineRunResultResourcesPipelinesItemReference value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Id is { } localId)
		{
			writer.WritePropertyName("id");
			writer.WriteNumberValue(localId);
		}
		if (value.Folder is { } localFolder)
		{
			writer.WritePropertyName("folder");
			writer.WriteStringValue(localFolder);
		}
		if (value.Name is { } localName)
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(localName);
		}
		if (value.Revision is { } localRevision)
		{
			writer.WritePropertyName("revision");
			writer.WriteNumberValue(localRevision);
		}
		if (value.Url is { } localUrl)
		{
			writer.WritePropertyName("url");
			writer.WriteStringValue(localUrl);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.PipelineRunResultResourcesPipelinesItemReference IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResultResourcesPipelinesItemReference>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.PipelineRunResultResourcesPipelinesItemReference();
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResultResourcesRepositories>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.PipelineRunResultResourcesRepositories value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.All is { } localAll)
		{
			writer.WritePropertyName("*");
			PipelineRunResultResourcesRepositoriesItem.Serialize(ref writer, localAll);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.PipelineRunResultResourcesRepositories IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResultResourcesRepositories>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.PipelineRunResultResourcesRepositories();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("*"))
					{
						obj.All = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => PipelineRunResultResourcesRepositoriesItem.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for All: {unexpected} ")
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResultResourcesRepositoriesItem>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.PipelineRunResultResourcesRepositoriesItem value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.RefName is { } localRefName)
		{
			writer.WritePropertyName("refName");
			writer.WriteStringValue(localRefName);
		}
		if (value.Repository is { } localRepository)
		{
			writer.WritePropertyName("repository");
			PipelineRunResultResourcesRepositoriesItemReference.Serialize(ref writer, localRepository);
		}
		if (value.Version is { } localVersion)
		{
			writer.WritePropertyName("version");
			writer.WriteStringValue(localVersion);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.PipelineRunResultResourcesRepositoriesItem IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResultResourcesRepositoriesItem>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.PipelineRunResultResourcesRepositoriesItem();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("refName"))
					{
						obj.RefName = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for RefName: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("repository"))
					{
						obj.Repository = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => PipelineRunResultResourcesRepositoriesItemReference.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Repository: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("version"))
					{
						obj.Version = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Version: {unexpected} ")
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResultResourcesRepositoriesItemReference>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.PipelineRunResultResourcesRepositoriesItemReference value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Id is { } localId)
		{
			writer.WritePropertyName("id");
			writer.WriteStringValue(localId);
		}
		if (value.Type is { } localType)
		{
			writer.WritePropertyName("type");
			writer.WriteStringValue(localType);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.PipelineRunResultResourcesRepositoriesItemReference IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResultResourcesRepositoriesItemReference>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.PipelineRunResultResourcesRepositoriesItemReference();
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
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Id: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("type"))
					{
						obj.Type = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Type: {unexpected} ")
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunsResult>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.PipelineRunsResult value)
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
			InternalSerializer3.Serialize(ref writer, localValue);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.PipelineRunsResult IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunsResult>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.PipelineRunsResult();
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
							JsonTokenType.StartArray => InternalSerializer3.Deserialize(ref reader, obj.Value ?? new()),
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunsResultItem>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.PipelineRunsResultItem value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Links is { } localLinks)
		{
			writer.WritePropertyName("_links");
			ReferenceLinks.Serialize(ref writer, localLinks);
		}
		if (value.CreatedDate is { } localCreatedDate)
		{
			writer.WritePropertyName("createdDate");
			writer.WriteStringValue(localCreatedDate);
		}
		if (value.FinishedDate is { } localFinishedDate)
		{
			writer.WritePropertyName("finishedDate");
			writer.WriteStringValue(localFinishedDate);
		}
		if (value.Id is { } localId)
		{
			writer.WritePropertyName("id");
			writer.WriteNumberValue(localId);
		}
		if (value.Name is { } localName)
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(localName);
		}
		if (value.Pipeline is { } localPipeline)
		{
			writer.WritePropertyName("pipeline");
			PipelineRunsResultItemPipeline.Serialize(ref writer, localPipeline);
		}
		if (value.State is { } localState)
		{
			writer.WritePropertyName("state");
			writer.WriteStringValue(localState);
		}
		if (value.Result is { } localResult)
		{
			writer.WritePropertyName("result");
			writer.WriteStringValue(localResult);
		}
		if (value.TemplateParameters is { } localTemplateParameters)
		{
			writer.WritePropertyName("templateParameters");
			TemplateParameters.Serialize(ref writer, localTemplateParameters);
		}
		if (value.Url is { } localUrl)
		{
			writer.WritePropertyName("url");
			writer.WriteStringValue(localUrl);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.PipelineRunsResultItem IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunsResultItem>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.PipelineRunsResultItem();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("_links"))
					{
						obj.Links = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => ReferenceLinks.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Links: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("createdDate"))
					{
						obj.CreatedDate = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for CreatedDate: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("finishedDate"))
					{
						obj.FinishedDate = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for FinishedDate: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("id"))
					{
						obj.Id = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.Number => reader.GetInt32(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Id: {unexpected} ")
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
					else if (reader.ValueTextEquals("pipeline"))
					{
						obj.Pipeline = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => PipelineRunsResultItemPipeline.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Pipeline: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("state"))
					{
						obj.State = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for State: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("result"))
					{
						obj.Result = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Result: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("templateParameters"))
					{
						obj.TemplateParameters = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => TemplateParameters.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for TemplateParameters: {unexpected} ")
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunsResultItemPipeline>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.PipelineRunsResultItemPipeline value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Id is { } localId)
		{
			writer.WritePropertyName("id");
			writer.WriteNumberValue(localId);
		}
		if (value.Folder is { } localFolder)
		{
			writer.WritePropertyName("folder");
			writer.WriteStringValue(localFolder);
		}
		if (value.Name is { } localName)
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(localName);
		}
		if (value.Revision is { } localRevision)
		{
			writer.WritePropertyName("revision");
			writer.WriteNumberValue(localRevision);
		}
		if (value.Url is { } localUrl)
		{
			writer.WritePropertyName("url");
			writer.WriteStringValue(localUrl);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.PipelineRunsResultItemPipeline IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunsResultItemPipeline>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.PipelineRunsResultItemPipeline();
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.TemplateParameters>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.TemplateParameters value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.TemplateParameters IJsonSerializer<Pingmint.AzureDevOps.Model.TemplateParameters>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.TemplateParameters();
		while (true)
		{
			switch (Next(ref reader))
			{
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
		if (value.All is { } localAll)
		{
			foreach (var (localAllKey, localAllValue) in localAll)
			{
				writer.WritePropertyName(localAllKey);
				ReferenceLink.Serialize(ref writer, localAllValue);
			}
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
					obj.All ??= new();
					var lhs = reader.GetString() ?? throw new NullReferenceException();
					var rhs = Next(ref reader) switch
					{
						JsonTokenType.Null => null,
						JsonTokenType.StartObject => ReferenceLink.Deserialize(ref reader),
						var unexpected => throw new InvalidOperationException($"unexpected token type for All: {unexpected} ")
					};
					obj.All.Add(lhs, rhs);
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
		public static void Serialize<TArray>(ref Utf8JsonWriter writer, TArray array) where TArray : ICollection<GitDiffsResultChange>
		{
			if (array is null) { writer.WriteNullValue(); return; }
			writer.WriteStartArray();
			foreach (var item in array)
			{
				GitDiffsResultChange.Serialize(ref writer, item);
			}
			writer.WriteEndArray();
		}

		public static TArray Deserialize<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<GitDiffsResultChange>
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
						var item = GitDiffsResultChange.Deserialize(ref reader);
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
	private static class InternalSerializer1
	{
		public static void Serialize<TArray>(ref Utf8JsonWriter writer, TArray array) where TArray : ICollection<String>
		{
			if (array is null) { writer.WriteNullValue(); return; }
			writer.WriteStartArray();
			foreach (var item in array)
			{
				writer.WriteStringValue(item);
			}
			writer.WriteEndArray();
		}

		public static TArray Deserialize<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<String>
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
					case JsonTokenType.String:
					{
						var item = reader.GetString();
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
	private static class InternalSerializer2
	{
		public static void Serialize<TArray>(ref Utf8JsonWriter writer, TArray array) where TArray : ICollection<PipelinesResultItem>
		{
			if (array is null) { writer.WriteNullValue(); return; }
			writer.WriteStartArray();
			foreach (var item in array)
			{
				PipelinesResultItem.Serialize(ref writer, item);
			}
			writer.WriteEndArray();
		}

		public static TArray Deserialize<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<PipelinesResultItem>
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
						var item = PipelinesResultItem.Deserialize(ref reader);
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
	private static class InternalSerializer3
	{
		public static void Serialize<TArray>(ref Utf8JsonWriter writer, TArray array) where TArray : ICollection<PipelineRunsResultItem>
		{
			if (array is null) { writer.WriteNullValue(); return; }
			writer.WriteStartArray();
			foreach (var item in array)
			{
				PipelineRunsResultItem.Serialize(ref writer, item);
			}
			writer.WriteEndArray();
		}

		public static TArray Deserialize<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<PipelineRunsResultItem>
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
						var item = PipelineRunsResultItem.Deserialize(ref reader);
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
public sealed partial class GitDiffsResult
{
	public int? aheadCount { get; set; }
	public bool? allChangesIncluded { get; set; }
	public int? behindCount { get; set; }
	public GitDiffsResultChangeCounts? changeCounts { get; set; }
	public String? commonCommit { get; set; }
	public List<GitDiffsResultChange>? changes { get; set; }
}
public sealed partial class GitDiffsResultChange
{
	public String? TODO { get; set; }
}
public sealed partial class GitDiffsResultChangeCounts
{
	public int? Add { get; set; }
	public int? Edit { get; set; }
}
public sealed partial class GitRepositoryResult
{
	public ReferenceLinks? Links { get; set; }
	public String? DefaultBranch { get; set; }
	public String? Id { get; set; }
	public String? Name { get; set; }
	public GitRepositoryResultProject? Project { get; set; }
	public String? RemoteUrl { get; set; }
	public int? Size { get; set; }
	public String? sshUrl { get; set; }
	public String? Url { get; set; }
	public String? webUrl { get; set; }
}
public sealed partial class TODO_GitRepositoryResult
{
	public int? IsDisabled { get; set; }
}
public sealed partial class GitRepositoryResultProject
{
	public String? id { get; set; }
	public String? name { get; set; }
	public String? url { get; set; }
	public String? state { get; set; }
	public int? revision { get; set; }
	public String? visibility { get; set; }
	public String? lastUpdateTime { get; set; }
}
public sealed partial class GitBranchStatsResults
{
	public int? aheadCount { get; set; }
	public int? behindCount { get; set; }
	public GitBranchStatsResultsCommit? commit { get; set; }
	public bool? isBaseVersion { get; set; }
	public String? name { get; set; }
}
public sealed partial class GitBranchStatsResultsCommit
{
	public String? treeId { get; set; }
	public String? commitId { get; set; }
	public GitBranchStatsResultsCommitPerson? author { get; set; }
	public GitBranchStatsResultsCommitPerson? committer { get; set; }
	public String? comment { get; set; }
	public List<String>? parents { get; set; }
	public String? url { get; set; }
}
public sealed partial class GitBranchStatsResultsCommitPerson
{
	public String? name { get; set; }
	public String? email { get; set; }
	public String? date { get; set; }
}
public sealed partial class PipelinesResult
{
	public int? Count { get; set; }
	public List<PipelinesResultItem>? Value { get; set; }
}
public sealed partial class PipelinesResultItem : IPipelineReference
{
	public int? Id { get; set; }
	public String? Folder { get; set; }
	public String? Name { get; set; }
	public int? Revision { get; set; }
	public String? Url { get; set; }
	public ReferenceLinks? Links { get; set; }
}
public sealed partial class PipelineRunResult : IPipelineRun
{
	public ReferenceLinks? Links { get; set; }
	public String? CreatedDate { get; set; }
	public String? FinishedDate { get; set; }
	public int? Id { get; set; }
	public String? Name { get; set; }
	public PipelineRunsResultItemPipeline? Pipeline { get; set; }
	public String? State { get; set; }
	public String? Result { get; set; }
	public TemplateParameters? TemplateParameters { get; set; }
	public String? Url { get; set; }
	public PipelineRunResultResources? Resources { get; set; }
}
public sealed partial class PipelineRunResultPipeline : IPipelineReference
{
	public int? Id { get; set; }
	public String? Folder { get; set; }
	public String? Name { get; set; }
	public int? Revision { get; set; }
	public String? Url { get; set; }
}
public sealed partial class PipelineRunResultResources
{
	public PipelineRunResultResourcesRepositories? Repositories { get; set; }
	public PipelineRunResultResourcesPipelines? Pipelines { get; set; }
}
public sealed partial class PipelineRunResultResourcesPipelines
{
	public PipelineRunResultResourcesPipelinesItem? All { get; set; }
}
public sealed partial class PipelineRunResultResourcesPipelinesItem
{
	public PipelineRunResultResourcesPipelinesItemReference? Pipeline { get; set; }
}
public sealed partial class PipelineRunResultResourcesPipelinesItemReference : IPipelineReference
{
	public int? Id { get; set; }
	public String? Folder { get; set; }
	public String? Name { get; set; }
	public int? Revision { get; set; }
	public String? Url { get; set; }
}
public sealed partial class PipelineRunResultResourcesRepositories
{
	public PipelineRunResultResourcesRepositoriesItem? All { get; set; }
}
public sealed partial class PipelineRunResultResourcesRepositoriesItem
{
	public String? RefName { get; set; }
	public PipelineRunResultResourcesRepositoriesItemReference? Repository { get; set; }
	public String? Version { get; set; }
}
public sealed partial class PipelineRunResultResourcesRepositoriesItemReference
{
	public String? Id { get; set; }
	public String? Type { get; set; }
}
public sealed partial class PipelineRunsResult
{
	public int? Count { get; set; }
	public List<PipelineRunsResultItem>? Value { get; set; }
}
public sealed partial class PipelineRunsResultItem : IPipelineRun
{
	public ReferenceLinks? Links { get; set; }
	public String? CreatedDate { get; set; }
	public String? FinishedDate { get; set; }
	public int? Id { get; set; }
	public String? Name { get; set; }
	public PipelineRunsResultItemPipeline? Pipeline { get; set; }
	public String? State { get; set; }
	public String? Result { get; set; }
	public TemplateParameters? TemplateParameters { get; set; }
	public String? Url { get; set; }
}
public sealed partial class PipelineRunsResultItemPipeline : IPipelineReference
{
	public int? Id { get; set; }
	public String? Folder { get; set; }
	public String? Name { get; set; }
	public int? Revision { get; set; }
	public String? Url { get; set; }
}
public sealed partial class TemplateParameters
{
}
public sealed partial class ReferenceLinks
{
	public ReferenceLink? Self { get; set; }
	public ReferenceLink? Web { get; set; }
	public Dictionary<String, ReferenceLink>? All { get; set; }
}
public sealed partial class ReferenceLink
{
	public String? Href { get; set; }
}
public partial interface IPipelineReference
{
	int? Id { get; set; }
	String? Folder { get; set; }
	String? Name { get; set; }
	int? Revision { get; set; }
	String? Url { get; set; }
}
public partial interface IPipelineRun
{
	ReferenceLinks? Links { get; set; }
	String? CreatedDate { get; set; }
	String? FinishedDate { get; set; }
	int? Id { get; set; }
	String? Name { get; set; }
	PipelineRunsResultItemPipeline? Pipeline { get; set; }
	String? State { get; set; }
	String? Result { get; set; }
	TemplateParameters? TemplateParameters { get; set; }
	String? Url { get; set; }
}
