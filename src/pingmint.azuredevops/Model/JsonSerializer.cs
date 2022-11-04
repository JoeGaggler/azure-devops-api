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
public sealed partial class JsonSerializer : IJsonSerializer<Pingmint.AzureDevOps.Model.GitBranchStats>, IJsonSerializer<Pingmint.AzureDevOps.Model.GitCommit>, IJsonSerializer<Pingmint.AzureDevOps.Model.GitDiffsChangeCounts>, IJsonSerializer<Pingmint.AzureDevOps.Model.GitDiffChange>, IJsonSerializer<Pingmint.AzureDevOps.Model.GitDiffChangeItem>, IJsonSerializer<Pingmint.AzureDevOps.Model.GitDiffs>, IJsonSerializer<Pingmint.AzureDevOps.Model.GitPerson>, IJsonSerializer<Pingmint.AzureDevOps.Model.GitRepository>, IJsonSerializer<Pingmint.AzureDevOps.Model.PipelinesResult>, IJsonSerializer<Pingmint.AzureDevOps.Model.Pipeline>, IJsonSerializer<Pingmint.AzureDevOps.Model.Project>, IJsonSerializer<Pingmint.AzureDevOps.Model.RunsResult>, IJsonSerializer<Pingmint.AzureDevOps.Model.Run>, IJsonSerializer<Pingmint.AzureDevOps.Model.RunResources>, IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResources>, IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResource>, IJsonSerializer<Pingmint.AzureDevOps.Model.RepositoryRunResources>, IJsonSerializer<Pingmint.AzureDevOps.Model.RepositoryRunResource>, IJsonSerializer<Pingmint.AzureDevOps.Model.Respository>, IJsonSerializer<Pingmint.AzureDevOps.Model.ReferenceLinks>, IJsonSerializer<Pingmint.AzureDevOps.Model.ReferenceLink>, IJsonSerializer<Pingmint.AzureDevOps.Model.TemplateParameters>
{
	public static readonly IJsonSerializer<GitBranchStats> GitBranchStats = new JsonSerializer();
	public static readonly IJsonSerializer<GitCommit> GitCommit = new JsonSerializer();
	public static readonly IJsonSerializer<GitDiffsChangeCounts> GitDiffsChangeCounts = new JsonSerializer();
	public static readonly IJsonSerializer<GitDiffChange> GitDiffChange = new JsonSerializer();
	public static readonly IJsonSerializer<GitDiffChangeItem> GitDiffChangeItem = new JsonSerializer();
	public static readonly IJsonSerializer<GitDiffs> GitDiffs = new JsonSerializer();
	public static readonly IJsonSerializer<GitPerson> GitPerson = new JsonSerializer();
	public static readonly IJsonSerializer<GitRepository> GitRepository = new JsonSerializer();
	public static readonly IJsonSerializer<PipelinesResult> PipelinesResult = new JsonSerializer();
	public static readonly IJsonSerializer<Pipeline> Pipeline = new JsonSerializer();
	public static readonly IJsonSerializer<Project> Project = new JsonSerializer();
	public static readonly IJsonSerializer<RunsResult> RunsResult = new JsonSerializer();
	public static readonly IJsonSerializer<Run> Run = new JsonSerializer();
	public static readonly IJsonSerializer<RunResources> RunResources = new JsonSerializer();
	public static readonly IJsonSerializer<PipelineRunResources> PipelineRunResources = new JsonSerializer();
	public static readonly IJsonSerializer<PipelineRunResource> PipelineRunResource = new JsonSerializer();
	public static readonly IJsonSerializer<RepositoryRunResources> RepositoryRunResources = new JsonSerializer();
	public static readonly IJsonSerializer<RepositoryRunResource> RepositoryRunResource = new JsonSerializer();
	public static readonly IJsonSerializer<Respository> Respository = new JsonSerializer();
	public static readonly IJsonSerializer<ReferenceLinks> ReferenceLinks = new JsonSerializer();
	public static readonly IJsonSerializer<ReferenceLink> ReferenceLink = new JsonSerializer();
	public static readonly IJsonSerializer<TemplateParameters> TemplateParameters = new JsonSerializer();

	private static JsonTokenType Next(ref Utf8JsonReader reader) => reader.Read() ? reader.TokenType : throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");

	void IJsonSerializer<Pingmint.AzureDevOps.Model.GitBranchStats>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.GitBranchStats value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Commit is { } localCommit)
		{
			writer.WritePropertyName("commit");
			GitCommit.Serialize(ref writer, localCommit);
		}
		if (value.Name is { } localName)
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(localName);
		}
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
		if (value.isBaseVersion is { } localisBaseVersion)
		{
			writer.WritePropertyName("isBaseVersion");
			writer.WriteBooleanValue(localisBaseVersion);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.GitBranchStats IJsonSerializer<Pingmint.AzureDevOps.Model.GitBranchStats>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.GitBranchStats();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("commit"))
					{
						obj.Commit = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GitCommit.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Commit: {unexpected} ")
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
					else if (reader.ValueTextEquals("aheadCount"))
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.GitCommit>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.GitCommit value)
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
			GitPerson.Serialize(ref writer, localauthor);
		}
		if (value.committer is { } localcommitter)
		{
			writer.WritePropertyName("committer");
			GitPerson.Serialize(ref writer, localcommitter);
		}
		if (value.comment is { } localcomment)
		{
			writer.WritePropertyName("comment");
			writer.WriteStringValue(localcomment);
		}
		if (value.Parents is { } localParents)
		{
			writer.WritePropertyName("parents");
			InternalSerializer0.Serialize(ref writer, localParents);
		}
		if (value.url is { } localurl)
		{
			writer.WritePropertyName("url");
			writer.WriteStringValue(localurl);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.GitCommit IJsonSerializer<Pingmint.AzureDevOps.Model.GitCommit>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.GitCommit();
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
							JsonTokenType.StartObject => GitPerson.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for author: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("committer"))
					{
						obj.committer = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GitPerson.Deserialize(ref reader),
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
						obj.Parents = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartArray => InternalSerializer0.Deserialize(ref reader, obj.Parents ?? new()),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Parents: {unexpected} ")
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.GitDiffsChangeCounts>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.GitDiffsChangeCounts value)
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

	Pingmint.AzureDevOps.Model.GitDiffsChangeCounts IJsonSerializer<Pingmint.AzureDevOps.Model.GitDiffsChangeCounts>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.GitDiffsChangeCounts();
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.GitDiffChange>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.GitDiffChange value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.item is { } localitem)
		{
			writer.WritePropertyName("item");
			GitDiffChangeItem.Serialize(ref writer, localitem);
		}
		if (value.changeType is { } localchangeType)
		{
			writer.WritePropertyName("changeType");
			writer.WriteStringValue(localchangeType);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.GitDiffChange IJsonSerializer<Pingmint.AzureDevOps.Model.GitDiffChange>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.GitDiffChange();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("item"))
					{
						obj.item = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GitDiffChangeItem.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for item: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("changeType"))
					{
						obj.changeType = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for changeType: {unexpected} ")
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.GitDiffChangeItem>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.GitDiffChangeItem value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.objectId is { } localobjectId)
		{
			writer.WritePropertyName("objectId");
			writer.WriteStringValue(localobjectId);
		}
		if (value.originalObjectId is { } localoriginalObjectId)
		{
			writer.WritePropertyName("originalObjectId");
			writer.WriteStringValue(localoriginalObjectId);
		}
		if (value.gitObjectType is { } localgitObjectType)
		{
			writer.WritePropertyName("gitObjectType");
			writer.WriteStringValue(localgitObjectType);
		}
		if (value.commitId is { } localcommitId)
		{
			writer.WritePropertyName("commitId");
			writer.WriteStringValue(localcommitId);
		}
		if (value.path is { } localpath)
		{
			writer.WritePropertyName("path");
			writer.WriteStringValue(localpath);
		}
		if (value.isFolder is { } localisFolder)
		{
			writer.WritePropertyName("isFolder");
			writer.WriteBooleanValue(localisFolder);
		}
		if (value.url is { } localurl)
		{
			writer.WritePropertyName("url");
			writer.WriteStringValue(localurl);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.GitDiffChangeItem IJsonSerializer<Pingmint.AzureDevOps.Model.GitDiffChangeItem>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.GitDiffChangeItem();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("objectId"))
					{
						obj.objectId = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for objectId: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("originalObjectId"))
					{
						obj.originalObjectId = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for originalObjectId: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("gitObjectType"))
					{
						obj.gitObjectType = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for gitObjectType: {unexpected} ")
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
					else if (reader.ValueTextEquals("path"))
					{
						obj.path = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for path: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("isFolder"))
					{
						obj.isFolder = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.True => reader.GetBoolean(),
							JsonTokenType.False => reader.GetBoolean(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for isFolder: {unexpected} ")
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.GitDiffs>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.GitDiffs value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.allChangesIncluded is { } localallChangesIncluded)
		{
			writer.WritePropertyName("allChangesIncluded");
			writer.WriteBooleanValue(localallChangesIncluded);
		}
		if (value.changeCounts is { } localchangeCounts)
		{
			writer.WritePropertyName("changeCounts");
			GitDiffsChangeCounts.Serialize(ref writer, localchangeCounts);
		}
		if (value.changes is { } localchanges)
		{
			writer.WritePropertyName("changes");
			InternalSerializer1.Serialize(ref writer, localchanges);
		}
		if (value.commonCommit is { } localcommonCommit)
		{
			writer.WritePropertyName("commonCommit");
			writer.WriteStringValue(localcommonCommit);
		}
		if (value.baseCommit is { } localbaseCommit)
		{
			writer.WritePropertyName("baseCommit");
			writer.WriteStringValue(localbaseCommit);
		}
		if (value.targetCommit is { } localtargetCommit)
		{
			writer.WritePropertyName("targetCommit");
			writer.WriteStringValue(localtargetCommit);
		}
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
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.GitDiffs IJsonSerializer<Pingmint.AzureDevOps.Model.GitDiffs>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.GitDiffs();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("allChangesIncluded"))
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
					else if (reader.ValueTextEquals("changeCounts"))
					{
						obj.changeCounts = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GitDiffsChangeCounts.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for changeCounts: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("changes"))
					{
						obj.changes = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartArray => InternalSerializer1.Deserialize(ref reader, obj.changes ?? new()),
							var unexpected => throw new InvalidOperationException($"unexpected token type for changes: {unexpected} ")
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
					else if (reader.ValueTextEquals("baseCommit"))
					{
						obj.baseCommit = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for baseCommit: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("targetCommit"))
					{
						obj.targetCommit = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for targetCommit: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("aheadCount"))
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.GitPerson>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.GitPerson value)
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

	Pingmint.AzureDevOps.Model.GitPerson IJsonSerializer<Pingmint.AzureDevOps.Model.GitPerson>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.GitPerson();
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.GitRepository>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.GitRepository value)
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
		if (value.isDisabled is { } localisDisabled)
		{
			writer.WritePropertyName("isDisabled");
			writer.WriteBooleanValue(localisDisabled);
		}
		if (value.Name is { } localName)
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(localName);
		}
		if (value.Project is { } localProject)
		{
			writer.WritePropertyName("project");
			Project.Serialize(ref writer, localProject);
		}
		if (value.remoteUrl is { } localremoteUrl)
		{
			writer.WritePropertyName("remoteUrl");
			writer.WriteStringValue(localremoteUrl);
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

	Pingmint.AzureDevOps.Model.GitRepository IJsonSerializer<Pingmint.AzureDevOps.Model.GitRepository>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.GitRepository();
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
					else if (reader.ValueTextEquals("isDisabled"))
					{
						obj.isDisabled = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.True => reader.GetBoolean(),
							JsonTokenType.False => reader.GetBoolean(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for isDisabled: {unexpected} ")
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
							JsonTokenType.StartObject => Project.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Project: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("remoteUrl"))
					{
						obj.remoteUrl = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for remoteUrl: {unexpected} ")
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.Pipeline>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.Pipeline value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Links is { } localLinks)
		{
			writer.WritePropertyName("_links");
			ReferenceLinks.Serialize(ref writer, localLinks);
		}
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

	Pingmint.AzureDevOps.Model.Pipeline IJsonSerializer<Pingmint.AzureDevOps.Model.Pipeline>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.Pipeline();
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.Project>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.Project value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
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
		if (value.Url is { } localUrl)
		{
			writer.WritePropertyName("url");
			writer.WriteStringValue(localUrl);
		}
		if (value.State is { } localState)
		{
			writer.WritePropertyName("state");
			writer.WriteStringValue(localState);
		}
		if (value.Revision is { } localRevision)
		{
			writer.WritePropertyName("revision");
			writer.WriteNumberValue(localRevision);
		}
		if (value.Visibility is { } localVisibility)
		{
			writer.WritePropertyName("visibility");
			writer.WriteStringValue(localVisibility);
		}
		if (value.LastUpdateTime is { } localLastUpdateTime)
		{
			writer.WritePropertyName("lastUpdateTime");
			writer.WriteStringValue(localLastUpdateTime);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.Project IJsonSerializer<Pingmint.AzureDevOps.Model.Project>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.Project();
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
					else if (reader.ValueTextEquals("visibility"))
					{
						obj.Visibility = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Visibility: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("lastUpdateTime"))
					{
						obj.LastUpdateTime = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for LastUpdateTime: {unexpected} ")
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.RunsResult>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.RunsResult value)
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

	Pingmint.AzureDevOps.Model.RunsResult IJsonSerializer<Pingmint.AzureDevOps.Model.RunsResult>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.RunsResult();
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.Run>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.Run value)
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
			Pipeline.Serialize(ref writer, localPipeline);
		}
		if (value.State is { } localState)
		{
			writer.WritePropertyName("state");
			writer.WriteStringValue(localState);
		}
		if (value.Resources is { } localResources)
		{
			writer.WritePropertyName("resources");
			RunResources.Serialize(ref writer, localResources);
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

	Pingmint.AzureDevOps.Model.Run IJsonSerializer<Pingmint.AzureDevOps.Model.Run>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.Run();
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
							JsonTokenType.StartObject => Pipeline.Deserialize(ref reader),
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
					else if (reader.ValueTextEquals("resources"))
					{
						obj.Resources = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => RunResources.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Resources: {unexpected} ")
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.RunResources>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.RunResources value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Pipelines is { } localPipelines)
		{
			writer.WritePropertyName("pipelines");
			PipelineRunResources.Serialize(ref writer, localPipelines);
		}
		if (value.Repositories is { } localRepositories)
		{
			writer.WritePropertyName("repositories");
			RepositoryRunResources.Serialize(ref writer, localRepositories);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.RunResources IJsonSerializer<Pingmint.AzureDevOps.Model.RunResources>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.RunResources();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("pipelines"))
					{
						obj.Pipelines = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => PipelineRunResources.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Pipelines: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("repositories"))
					{
						obj.Repositories = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => RepositoryRunResources.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Repositories: {unexpected} ")
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResources>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.PipelineRunResources value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.All is { } localAll)
		{
			foreach (var (localAllKey, localAllValue) in localAll)
			{
				writer.WritePropertyName(localAllKey);
				PipelineRunResource.Serialize(ref writer, localAllValue);
			}
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.PipelineRunResources IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResources>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.PipelineRunResources();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					obj.All ??= new();
					var lhs = reader.GetString() ?? throw new NullReferenceException();
					var rhs = Next(ref reader) switch
					{
						JsonTokenType.Null => null,
						JsonTokenType.StartObject => PipelineRunResource.Deserialize(ref reader),
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResource>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.PipelineRunResource value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Pipeline is { } localPipeline)
		{
			writer.WritePropertyName("pipeline");
			Pipeline.Serialize(ref writer, localPipeline);
		}
		if (value.Version is { } localVersion)
		{
			writer.WritePropertyName("version");
			writer.WriteStringValue(localVersion);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.PipelineRunResource IJsonSerializer<Pingmint.AzureDevOps.Model.PipelineRunResource>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.PipelineRunResource();
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
							JsonTokenType.StartObject => Pipeline.Deserialize(ref reader),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Pipeline: {unexpected} ")
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.RepositoryRunResources>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.RepositoryRunResources value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.All is { } localAll)
		{
			foreach (var (localAllKey, localAllValue) in localAll)
			{
				writer.WritePropertyName(localAllKey);
				RepositoryRunResource.Serialize(ref writer, localAllValue);
			}
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.RepositoryRunResources IJsonSerializer<Pingmint.AzureDevOps.Model.RepositoryRunResources>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.RepositoryRunResources();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					obj.All ??= new();
					var lhs = reader.GetString() ?? throw new NullReferenceException();
					var rhs = Next(ref reader) switch
					{
						JsonTokenType.Null => null,
						JsonTokenType.StartObject => RepositoryRunResource.Deserialize(ref reader),
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.RepositoryRunResource>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.RepositoryRunResource value)
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
			Respository.Serialize(ref writer, localRepository);
		}
		if (value.Version is { } localVersion)
		{
			writer.WritePropertyName("version");
			writer.WriteStringValue(localVersion);
		}
		writer.WriteEndObject();
	}

	Pingmint.AzureDevOps.Model.RepositoryRunResource IJsonSerializer<Pingmint.AzureDevOps.Model.RepositoryRunResource>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.RepositoryRunResource();
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
							JsonTokenType.StartObject => Respository.Deserialize(ref reader),
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
	void IJsonSerializer<Pingmint.AzureDevOps.Model.Respository>.Serialize(ref Utf8JsonWriter writer, Pingmint.AzureDevOps.Model.Respository value)
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

	Pingmint.AzureDevOps.Model.Respository IJsonSerializer<Pingmint.AzureDevOps.Model.Respository>.Deserialize(ref Utf8JsonReader reader)
	{
		var obj = new Pingmint.AzureDevOps.Model.Respository();
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
	private static class InternalSerializer0
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
	private static class InternalSerializer1
	{
		public static void Serialize<TArray>(ref Utf8JsonWriter writer, TArray array) where TArray : ICollection<GitDiffChange>
		{
			if (array is null) { writer.WriteNullValue(); return; }
			writer.WriteStartArray();
			foreach (var item in array)
			{
				GitDiffChange.Serialize(ref writer, item);
			}
			writer.WriteEndArray();
		}

		public static TArray Deserialize<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<GitDiffChange>
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
						var item = GitDiffChange.Deserialize(ref reader);
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
	private static class InternalSerializer3
	{
		public static void Serialize<TArray>(ref Utf8JsonWriter writer, TArray array) where TArray : ICollection<Run>
		{
			if (array is null) { writer.WriteNullValue(); return; }
			writer.WriteStartArray();
			foreach (var item in array)
			{
				Run.Serialize(ref writer, item);
			}
			writer.WriteEndArray();
		}

		public static TArray Deserialize<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<Run>
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
						var item = Run.Deserialize(ref reader);
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
public sealed partial class GitBranchStats
{
	public GitCommit? Commit { get; set; }
	public String? Name { get; set; }
	public int? aheadCount { get; set; }
	public int? behindCount { get; set; }
	public bool? isBaseVersion { get; set; }
}
public sealed partial class GitCommit
{
	public String? treeId { get; set; }
	public String? commitId { get; set; }
	public GitPerson? author { get; set; }
	public GitPerson? committer { get; set; }
	public String? comment { get; set; }
	public List<String>? Parents { get; set; }
	public String? url { get; set; }
}
public sealed partial class GitDiffsChangeCounts
{
	public int? Add { get; set; }
	public int? Edit { get; set; }
}
public sealed partial class GitDiffChange
{
	public GitDiffChangeItem? item { get; set; }
	public String? changeType { get; set; }
}
public sealed partial class GitDiffChangeItem
{
	public String? objectId { get; set; }
	public String? originalObjectId { get; set; }
	public String? gitObjectType { get; set; }
	public String? commitId { get; set; }
	public String? path { get; set; }
	public bool? isFolder { get; set; }
	public String? url { get; set; }
}
public sealed partial class GitDiffs
{
	public bool? allChangesIncluded { get; set; }
	public GitDiffsChangeCounts? changeCounts { get; set; }
	public List<GitDiffChange>? changes { get; set; }
	public String? commonCommit { get; set; }
	public String? baseCommit { get; set; }
	public String? targetCommit { get; set; }
	public int? aheadCount { get; set; }
	public int? behindCount { get; set; }
}
public sealed partial class GitPerson
{
	public String? name { get; set; }
	public String? email { get; set; }
	public String? date { get; set; }
}
public sealed partial class GitRepository : ILinks
{
	public ReferenceLinks? Links { get; set; }
	public String? DefaultBranch { get; set; }
	public String? Id { get; set; }
	public bool? isDisabled { get; set; }
	public String? Name { get; set; }
	public Project? Project { get; set; }
	public String? remoteUrl { get; set; }
	public int? Size { get; set; }
	public String? sshUrl { get; set; }
	public String? Url { get; set; }
	public String? webUrl { get; set; }
}
public sealed partial class PipelinesResult
{
	public int? Count { get; set; }
	public List<Pipeline>? Value { get; set; }
}
public sealed partial class Pipeline : ILinks
{
	public ReferenceLinks? Links { get; set; }
	public int? Id { get; set; }
	public String? Folder { get; set; }
	public String? Name { get; set; }
	public int? Revision { get; set; }
	public String? Url { get; set; }
}
public sealed partial class Project
{
	public String? Id { get; set; }
	public String? Name { get; set; }
	public String? Url { get; set; }
	public String? State { get; set; }
	public int? Revision { get; set; }
	public String? Visibility { get; set; }
	public String? LastUpdateTime { get; set; }
}
public sealed partial class RunsResult
{
	public int? Count { get; set; }
	public List<Run>? Value { get; set; }
}
public sealed partial class Run : ILinks
{
	public ReferenceLinks? Links { get; set; }
	public String? CreatedDate { get; set; }
	public String? FinishedDate { get; set; }
	public int? Id { get; set; }
	public String? Name { get; set; }
	public Pipeline? Pipeline { get; set; }
	public String? State { get; set; }
	public RunResources? Resources { get; set; }
	public String? Result { get; set; }
	public TemplateParameters? TemplateParameters { get; set; }
	public String? Url { get; set; }
}
public sealed partial class RunResources
{
	public PipelineRunResources? Pipelines { get; set; }
	public RepositoryRunResources? Repositories { get; set; }
}
public sealed partial class PipelineRunResources
{
	public Dictionary<String, PipelineRunResource>? All { get; set; }
}
public sealed partial class PipelineRunResource
{
	public Pipeline? Pipeline { get; set; }
	public String? Version { get; set; }
}
public sealed partial class RepositoryRunResources
{
	public Dictionary<String, RepositoryRunResource>? All { get; set; }
}
public sealed partial class RepositoryRunResource
{
	public String? RefName { get; set; }
	public Respository? Repository { get; set; }
	public String? Version { get; set; }
}
public sealed partial class Respository
{
	public String? Id { get; set; }
	public String? Type { get; set; }
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
public partial interface ILinks
{
	ReferenceLinks? Links { get; set; }
}
public sealed partial class TemplateParameters
{
}
