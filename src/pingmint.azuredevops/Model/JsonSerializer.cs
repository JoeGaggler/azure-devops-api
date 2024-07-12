#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Pingmint.AzureDevOps.Model;

public static partial class JsonSerializer
{
	private static JsonTokenType Next(ref Utf8JsonReader reader) => reader.Read() ? reader.TokenType : throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");

	private delegate void DeserializerDelegate<T>(ref Utf8JsonReader r, out T value);
	private static T GetOutParam<T>(ref Utf8JsonReader reader, DeserializerDelegate<T> func) { func(ref reader, out T value); return value; }

	public static void Serialize(Utf8JsonWriter writer, GitBranchStats value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Commit is { } localCommit)
		{
			writer.WritePropertyName("commit");
			Serialize(writer, localCommit);
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

	public static void Deserialize(ref Utf8JsonReader reader, out GitBranchStats obj)
	{
		obj = new GitBranchStats();
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
							JsonTokenType.StartObject => GetOutParam<GitCommit>(ref reader, Deserialize),
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
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitCommit value)
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
			Serialize(writer, localauthor);
		}
		if (value.committer is { } localcommitter)
		{
			writer.WritePropertyName("committer");
			Serialize(writer, localcommitter);
		}
		if (value.comment is { } localcomment)
		{
			writer.WritePropertyName("comment");
			writer.WriteStringValue(localcomment);
		}
		if (value.Parents is { } localParents)
		{
			writer.WritePropertyName("parents");
			Serialize0(writer, localParents);
		}
		if (value.url is { } localurl)
		{
			writer.WritePropertyName("url");
			writer.WriteStringValue(localurl);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out GitCommit obj)
	{
		obj = new GitCommit();
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
							JsonTokenType.StartObject => GetOutParam<GitPerson>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for author: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("committer"))
					{
						obj.committer = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GetOutParam<GitPerson>(ref reader, Deserialize),
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
							JsonTokenType.StartArray => Deserialize0(ref reader, obj.Parents ?? new()),
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
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitCommitRef value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.commitId is { } localcommitId)
		{
			writer.WritePropertyName("commitId");
			writer.WriteStringValue(localcommitId);
		}
		if (value.url is { } localurl)
		{
			writer.WritePropertyName("url");
			writer.WriteStringValue(localurl);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out GitCommitRef obj)
	{
		obj = new GitCommitRef();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("commitId"))
					{
						obj.commitId = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for commitId: {unexpected} ")
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
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitDiffsChangeCounts value)
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

	public static void Deserialize(ref Utf8JsonReader reader, out GitDiffsChangeCounts obj)
	{
		obj = new GitDiffsChangeCounts();
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
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitDiffChange value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.item is { } localitem)
		{
			writer.WritePropertyName("item");
			Serialize(writer, localitem);
		}
		if (value.changeType is { } localchangeType)
		{
			writer.WritePropertyName("changeType");
			writer.WriteStringValue(localchangeType);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out GitDiffChange obj)
	{
		obj = new GitDiffChange();
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
							JsonTokenType.StartObject => GetOutParam<GitDiffChangeItem>(ref reader, Deserialize),
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
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitDiffChangeItem value)
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

	public static void Deserialize(ref Utf8JsonReader reader, out GitDiffChangeItem obj)
	{
		obj = new GitDiffChangeItem();
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
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitDiffs value)
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
			Serialize(writer, localchangeCounts);
		}
		if (value.changes is { } localchanges)
		{
			writer.WritePropertyName("changes");
			Serialize1(writer, localchanges);
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

	public static void Deserialize(ref Utf8JsonReader reader, out GitDiffs obj)
	{
		obj = new GitDiffs();
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
							JsonTokenType.StartObject => GetOutParam<GitDiffsChangeCounts>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for changeCounts: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("changes"))
					{
						obj.changes = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartArray => Deserialize1(ref reader, obj.changes ?? new()),
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
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitMergeRequest value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Comment is { } localComment)
		{
			writer.WritePropertyName("comment");
			writer.WriteStringValue(localComment);
		}
		if (value.Parents is { } localParents)
		{
			writer.WritePropertyName("parents");
			Serialize2(writer, localParents);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out GitMergeRequest obj)
	{
		obj = new GitMergeRequest();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("comment"))
					{
						obj.Comment = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Comment: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("parents"))
					{
						obj.Parents = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartArray => Deserialize2(ref reader, obj.Parents ?? new()),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Parents: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitMergeResult value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Status is { } localStatus)
		{
			writer.WritePropertyName("status");
			writer.WriteStringValue(localStatus);
		}
		if (value.MergeOperationId is { } localMergeOperationId)
		{
			writer.WritePropertyName("mergeOperationId");
			writer.WriteNumberValue(localMergeOperationId);
		}
		if (value.DetailedStatus is { } localDetailedStatus)
		{
			writer.WritePropertyName("detailedStatus");
			Serialize(writer, localDetailedStatus);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out GitMergeResult obj)
	{
		obj = new GitMergeResult();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("status"))
					{
						obj.Status = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Status: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("mergeOperationId"))
					{
						obj.MergeOperationId = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.Number => reader.GetInt32(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for MergeOperationId: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("detailedStatus"))
					{
						obj.DetailedStatus = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GetOutParam<GitMergeOperationStatusDetail>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for DetailedStatus: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitMergeOperationStatusDetail value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.MergeCommitId is { } localMergeCommitId)
		{
			writer.WritePropertyName("mergeCommitId");
			writer.WriteStringValue(localMergeCommitId);
		}
		if (value.FailureMessage is { } localFailureMessage)
		{
			writer.WritePropertyName("failureMessage");
			writer.WriteStringValue(localFailureMessage);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out GitMergeOperationStatusDetail obj)
	{
		obj = new GitMergeOperationStatusDetail();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("mergeCommitId"))
					{
						obj.MergeCommitId = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for MergeCommitId: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("failureMessage"))
					{
						obj.FailureMessage = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for FailureMessage: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitPerson value)
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

	public static void Deserialize(ref Utf8JsonReader reader, out GitPerson obj)
	{
		obj = new GitPerson();
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
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitPullRequest value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.PullRequestId is { } localPullRequestId)
		{
			writer.WritePropertyName("pullRequestId");
			writer.WriteNumberValue(localPullRequestId);
		}
		if (value.Title is { } localTitle)
		{
			writer.WritePropertyName("title");
			writer.WriteStringValue(localTitle);
		}
		if (value.Description is { } localDescription)
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(localDescription);
		}
		if (value.Status is { } localStatus)
		{
			writer.WritePropertyName("status");
			writer.WriteStringValue(localStatus);
		}
		if (value.SourceRefName is { } localSourceRefName)
		{
			writer.WritePropertyName("sourceRefName");
			writer.WriteStringValue(localSourceRefName);
		}
		if (value.TargetRefName is { } localTargetRefName)
		{
			writer.WritePropertyName("targetRefName");
			writer.WriteStringValue(localTargetRefName);
		}
		if (value.LastMergeCommit is { } localLastMergeCommit)
		{
			writer.WritePropertyName("lastMergeCommit");
			Serialize(writer, localLastMergeCommit);
		}
		if (value.LastMergeSourceCommit is { } localLastMergeSourceCommit)
		{
			writer.WritePropertyName("lastMergeSourceCommit");
			Serialize(writer, localLastMergeSourceCommit);
		}
		if (value.LastMergeTargetCommit is { } localLastMergeTargetCommit)
		{
			writer.WritePropertyName("lastMergeTargetCommit");
			Serialize(writer, localLastMergeTargetCommit);
		}
		if (value.MergeId is { } localMergeId)
		{
			writer.WritePropertyName("mergeId");
			writer.WriteStringValue(localMergeId);
		}
		if (value.MergeStatus is { } localMergeStatus)
		{
			writer.WritePropertyName("mergeStatus");
			writer.WriteStringValue(localMergeStatus);
		}
		if (value.Url is { } localUrl)
		{
			writer.WritePropertyName("url");
			writer.WriteStringValue(localUrl);
		}
		if (value.IsDraft is { } localIsDraft)
		{
			writer.WritePropertyName("isDraft");
			writer.WriteBooleanValue(localIsDraft);
		}
		if (value.Reviewers is { } localReviewers)
		{
			writer.WritePropertyName("reviewers");
			Serialize3(writer, localReviewers);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out GitPullRequest obj)
	{
		obj = new GitPullRequest();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("pullRequestId"))
					{
						obj.PullRequestId = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.Number => reader.GetInt32(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for PullRequestId: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("title"))
					{
						obj.Title = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Title: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("description"))
					{
						obj.Description = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Description: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("status"))
					{
						obj.Status = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Status: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("sourceRefName"))
					{
						obj.SourceRefName = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for SourceRefName: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("targetRefName"))
					{
						obj.TargetRefName = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for TargetRefName: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("lastMergeCommit"))
					{
						obj.LastMergeCommit = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GetOutParam<GitCommitRef>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for LastMergeCommit: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("lastMergeSourceCommit"))
					{
						obj.LastMergeSourceCommit = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GetOutParam<GitCommitRef>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for LastMergeSourceCommit: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("lastMergeTargetCommit"))
					{
						obj.LastMergeTargetCommit = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GetOutParam<GitCommitRef>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for LastMergeTargetCommit: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("mergeId"))
					{
						obj.MergeId = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for MergeId: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("mergeStatus"))
					{
						obj.MergeStatus = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for MergeStatus: {unexpected} ")
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
					else if (reader.ValueTextEquals("isDraft"))
					{
						obj.IsDraft = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.True => reader.GetBoolean(),
							JsonTokenType.False => reader.GetBoolean(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for IsDraft: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("reviewers"))
					{
						obj.Reviewers = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartArray => Deserialize3(ref reader, obj.Reviewers ?? new()),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Reviewers: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, IdentityRefWithVote value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Id is { } localId)
		{
			writer.WritePropertyName("id");
			writer.WriteStringValue(localId);
		}
		if (value.DisplayName is { } localDisplayName)
		{
			writer.WritePropertyName("displayName");
			writer.WriteStringValue(localDisplayName);
		}
		if (value.UniqueName is { } localUniqueName)
		{
			writer.WritePropertyName("uniqueName");
			writer.WriteStringValue(localUniqueName);
		}
		if (value.Url is { } localUrl)
		{
			writer.WritePropertyName("url");
			writer.WriteStringValue(localUrl);
		}
		if (value.ImageUrl is { } localImageUrl)
		{
			writer.WritePropertyName("imageUrl");
			writer.WriteStringValue(localImageUrl);
		}
		if (value.IsContainer is { } localIsContainer)
		{
			writer.WritePropertyName("isContainer");
			writer.WriteBooleanValue(localIsContainer);
		}
		if (value.IsRequired is { } localIsRequired)
		{
			writer.WritePropertyName("isRequired");
			writer.WriteBooleanValue(localIsRequired);
		}
		if (value.Vote is { } localVote)
		{
			writer.WritePropertyName("vote");
			writer.WriteNumberValue(localVote);
		}
		if (value.ReviewerUrl is { } localReviewerUrl)
		{
			writer.WritePropertyName("reviewerUrl");
			writer.WriteStringValue(localReviewerUrl);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out IdentityRefWithVote obj)
	{
		obj = new IdentityRefWithVote();
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
					else if (reader.ValueTextEquals("displayName"))
					{
						obj.DisplayName = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for DisplayName: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("uniqueName"))
					{
						obj.UniqueName = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for UniqueName: {unexpected} ")
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
					else if (reader.ValueTextEquals("imageUrl"))
					{
						obj.ImageUrl = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for ImageUrl: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("isContainer"))
					{
						obj.IsContainer = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.True => reader.GetBoolean(),
							JsonTokenType.False => reader.GetBoolean(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for IsContainer: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("isRequired"))
					{
						obj.IsRequired = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.True => reader.GetBoolean(),
							JsonTokenType.False => reader.GetBoolean(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for IsRequired: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("vote"))
					{
						obj.Vote = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.Number => reader.GetInt32(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Vote: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("reviewerUrl"))
					{
						obj.ReviewerUrl = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for ReviewerUrl: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitPullRequestResponse value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Value is { } localValue)
		{
			writer.WritePropertyName("value");
			Serialize4(writer, localValue);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out GitPullRequestResponse obj)
	{
		obj = new GitPullRequestResponse();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("value"))
					{
						obj.Value = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartArray => Deserialize4(ref reader, obj.Value ?? new()),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Value: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, CreateGitPullRequestStatusesRequest value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Iteration is { } localIteration)
		{
			writer.WritePropertyName("iteration");
			writer.WriteNumberValue(localIteration);
		}
		if (value.State is { } localState)
		{
			writer.WritePropertyName("state");
			writer.WriteStringValue(localState);
		}
		if (value.Description is { } localDescription)
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(localDescription);
		}
		if (value.Context is { } localContext)
		{
			writer.WritePropertyName("context");
			Serialize(writer, localContext);
		}
		if (value.TargetUrl is { } localTargetUrl)
		{
			writer.WritePropertyName("targetUrl");
			writer.WriteStringValue(localTargetUrl);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out CreateGitPullRequestStatusesRequest obj)
	{
		obj = new CreateGitPullRequestStatusesRequest();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("iteration"))
					{
						obj.Iteration = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.Number => reader.GetInt32(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Iteration: {unexpected} ")
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
					else if (reader.ValueTextEquals("description"))
					{
						obj.Description = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Description: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("context"))
					{
						obj.Context = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GetOutParam<GitStatusContext>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Context: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("targetUrl"))
					{
						obj.TargetUrl = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for TargetUrl: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitPullRequestStatus value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Id is { } localId)
		{
			writer.WritePropertyName("id");
			writer.WriteNumberValue(localId);
		}
		if (value.State is { } localState)
		{
			writer.WritePropertyName("state");
			writer.WriteStringValue(localState);
		}
		if (value.Description is { } localDescription)
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(localDescription);
		}
		if (value.Context is { } localContext)
		{
			writer.WritePropertyName("context");
			Serialize(writer, localContext);
		}
		if (value.CreationDate is { } localCreationDate)
		{
			writer.WritePropertyName("creationDate");
			writer.WriteStringValue(localCreationDate);
		}
		if (value.UpdatedDate is { } localUpdatedDate)
		{
			writer.WritePropertyName("updatedDate");
			writer.WriteStringValue(localUpdatedDate);
		}
		if (value.CreatedBy is { } localCreatedBy)
		{
			writer.WritePropertyName("createdBy");
			Serialize(writer, localCreatedBy);
		}
		if (value.TargetUrl is { } localTargetUrl)
		{
			writer.WritePropertyName("targetUrl");
			writer.WriteStringValue(localTargetUrl);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out GitPullRequestStatus obj)
	{
		obj = new GitPullRequestStatus();
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
					else if (reader.ValueTextEquals("description"))
					{
						obj.Description = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Description: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("context"))
					{
						obj.Context = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GetOutParam<GitStatusContext>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Context: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("creationDate"))
					{
						obj.CreationDate = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for CreationDate: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("updatedDate"))
					{
						obj.UpdatedDate = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for UpdatedDate: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("createdBy"))
					{
						obj.CreatedBy = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GetOutParam<IdentityRef>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for CreatedBy: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("targetUrl"))
					{
						obj.TargetUrl = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for TargetUrl: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitStatusContext value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Genre is { } localGenre)
		{
			writer.WritePropertyName("genre");
			writer.WriteStringValue(localGenre);
		}
		if (value.Name is { } localName)
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(localName);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out GitStatusContext obj)
	{
		obj = new GitStatusContext();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("genre"))
					{
						obj.Genre = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Genre: {unexpected} ")
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

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitPullRequestStatusesResponse value)
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
			Serialize5(writer, localValue);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out GitPullRequestStatusesResponse obj)
	{
		obj = new GitPullRequestStatusesResponse();
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
							JsonTokenType.StartArray => Deserialize5(ref reader, obj.Value ?? new()),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Value: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitRef value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Name is { } localName)
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(localName);
		}
		if (value.ObjectId is { } localObjectId)
		{
			writer.WritePropertyName("objectId");
			writer.WriteStringValue(localObjectId);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out GitRef obj)
	{
		obj = new GitRef();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("name"))
					{
						obj.Name = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Name: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("objectId"))
					{
						obj.ObjectId = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for ObjectId: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitRefResult value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Value is { } localValue)
		{
			writer.WritePropertyName("value");
			Serialize6(writer, localValue);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out GitRefResult obj)
	{
		obj = new GitRefResult();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("value"))
					{
						obj.Value = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartArray => Deserialize6(ref reader, obj.Value ?? new()),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Value: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitRefUpdate value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Name is { } localName)
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(localName);
		}
		if (value.OldObjectId is { } localOldObjectId)
		{
			writer.WritePropertyName("oldObjectId");
			writer.WriteStringValue(localOldObjectId);
		}
		if (value.NewObjectId is { } localNewObjectId)
		{
			writer.WritePropertyName("newObjectId");
			writer.WriteStringValue(localNewObjectId);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out GitRefUpdate obj)
	{
		obj = new GitRefUpdate();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("name"))
					{
						obj.Name = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Name: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("oldObjectId"))
					{
						obj.OldObjectId = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for OldObjectId: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("newObjectId"))
					{
						obj.NewObjectId = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for NewObjectId: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitRefUpdateRequest value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Value is { } localValue)
		{
			writer.WritePropertyName("value");
			Serialize7(writer, localValue);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out GitRefUpdateRequest obj)
	{
		obj = new GitRefUpdateRequest();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("value"))
					{
						obj.Value = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartArray => Deserialize7(ref reader, obj.Value ?? new()),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Value: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitRefUpdateResponse value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Value is { } localValue)
		{
			writer.WritePropertyName("value");
			Serialize8(writer, localValue);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out GitRefUpdateResponse obj)
	{
		obj = new GitRefUpdateResponse();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("value"))
					{
						obj.Value = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartArray => Deserialize8(ref reader, obj.Value ?? new()),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Value: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitRefUpdateResult value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Name is { } localName)
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(localName);
		}
		if (value.OldObjectId is { } localOldObjectId)
		{
			writer.WritePropertyName("oldObjectId");
			writer.WriteStringValue(localOldObjectId);
		}
		if (value.NewObjectId is { } localNewObjectId)
		{
			writer.WritePropertyName("newObjectId");
			writer.WriteStringValue(localNewObjectId);
		}
		if (value.WasSuccessful is { } localWasSuccessful)
		{
			writer.WritePropertyName("success");
			writer.WriteBooleanValue(localWasSuccessful);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out GitRefUpdateResult obj)
	{
		obj = new GitRefUpdateResult();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("name"))
					{
						obj.Name = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Name: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("oldObjectId"))
					{
						obj.OldObjectId = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for OldObjectId: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("newObjectId"))
					{
						obj.NewObjectId = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for NewObjectId: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("success"))
					{
						obj.WasSuccessful = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.True => reader.GetBoolean(),
							JsonTokenType.False => reader.GetBoolean(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for WasSuccessful: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitRepository value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Links is { } localLinks)
		{
			writer.WritePropertyName("_links");
			Serialize(writer, localLinks);
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
			Serialize(writer, localProject);
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

	public static void Deserialize(ref Utf8JsonReader reader, out GitRepository obj)
	{
		obj = new GitRepository();
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
							JsonTokenType.StartObject => GetOutParam<ReferenceLinks>(ref reader, Deserialize),
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
							JsonTokenType.StartObject => GetOutParam<Project>(ref reader, Deserialize),
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
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, PipelineRunRequest value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.StagesToSkip is { } localStagesToSkip)
		{
			writer.WritePropertyName("stagesToSkip");
			Serialize9(writer, localStagesToSkip);
		}
		if (value.Resources is { } localResources)
		{
			writer.WritePropertyName("resources");
			Serialize(writer, localResources);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out PipelineRunRequest obj)
	{
		obj = new PipelineRunRequest();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("stagesToSkip"))
					{
						obj.StagesToSkip = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartArray => Deserialize9(ref reader, obj.StagesToSkip ?? new()),
							var unexpected => throw new InvalidOperationException($"unexpected token type for StagesToSkip: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("resources"))
					{
						obj.Resources = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GetOutParam<RunResources>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Resources: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, PipelinesResult value)
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
			Serialize10(writer, localValue);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out PipelinesResult obj)
	{
		obj = new PipelinesResult();
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
							JsonTokenType.StartArray => Deserialize10(ref reader, obj.Value ?? new()),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Value: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, Pipeline value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Links is { } localLinks)
		{
			writer.WritePropertyName("_links");
			Serialize(writer, localLinks);
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

	public static void Deserialize(ref Utf8JsonReader reader, out Pipeline obj)
	{
		obj = new Pipeline();
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
							JsonTokenType.StartObject => GetOutParam<ReferenceLinks>(ref reader, Deserialize),
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
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, Project value)
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

	public static void Deserialize(ref Utf8JsonReader reader, out Project obj)
	{
		obj = new Project();
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
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, RunsResult value)
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
			Serialize11(writer, localValue);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out RunsResult obj)
	{
		obj = new RunsResult();
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
							JsonTokenType.StartArray => Deserialize11(ref reader, obj.Value ?? new()),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Value: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, Run value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Links is { } localLinks)
		{
			writer.WritePropertyName("_links");
			Serialize(writer, localLinks);
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
			Serialize(writer, localPipeline);
		}
		if (value.State is { } localState)
		{
			writer.WritePropertyName("state");
			writer.WriteStringValue(localState);
		}
		if (value.Resources is { } localResources)
		{
			writer.WritePropertyName("resources");
			Serialize(writer, localResources);
		}
		if (value.Result is { } localResult)
		{
			writer.WritePropertyName("result");
			writer.WriteStringValue(localResult);
		}
		if (value.TemplateParameters is { } localTemplateParameters)
		{
			writer.WritePropertyName("templateParameters");
			Serialize(writer, localTemplateParameters);
		}
		if (value.Url is { } localUrl)
		{
			writer.WritePropertyName("url");
			writer.WriteStringValue(localUrl);
		}
		if (value.Variables is { } localVariables)
		{
			writer.WritePropertyName("variables");
			Serialize(writer, localVariables);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out Run obj)
	{
		obj = new Run();
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
							JsonTokenType.StartObject => GetOutParam<ReferenceLinks>(ref reader, Deserialize),
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
							JsonTokenType.StartObject => GetOutParam<Pipeline>(ref reader, Deserialize),
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
							JsonTokenType.StartObject => GetOutParam<RunResources>(ref reader, Deserialize),
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
							JsonTokenType.StartObject => GetOutParam<TemplateParameters>(ref reader, Deserialize),
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
					else if (reader.ValueTextEquals("variables"))
					{
						obj.Variables = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GetOutParam<Variables>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Variables: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, RunResources value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Pipelines is { } localPipelines)
		{
			writer.WritePropertyName("pipelines");
			Serialize(writer, localPipelines);
		}
		if (value.Repositories is { } localRepositories)
		{
			writer.WritePropertyName("repositories");
			Serialize(writer, localRepositories);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out RunResources obj)
	{
		obj = new RunResources();
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
							JsonTokenType.StartObject => GetOutParam<PipelineRunResources>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Pipelines: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("repositories"))
					{
						obj.Repositories = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GetOutParam<RepositoryRunResources>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Repositories: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, PipelineRunResources value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.All is { } localAll)
		{
			foreach (var (localAllKey, localAllValue) in localAll)
			{
				writer.WritePropertyName(localAllKey);
				Serialize(writer, localAllValue);
			}
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out PipelineRunResources obj)
	{
		obj = new PipelineRunResources();
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
						JsonTokenType.StartObject => GetOutParam<PipelineRunResource>(ref reader, Deserialize),
						var unexpected => throw new InvalidOperationException($"unexpected token type for All: {unexpected} ")
					};
					obj.All.Add(lhs, rhs);
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, PipelineRunResource value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Pipeline is { } localPipeline)
		{
			writer.WritePropertyName("pipeline");
			Serialize(writer, localPipeline);
		}
		if (value.Version is { } localVersion)
		{
			writer.WritePropertyName("version");
			writer.WriteStringValue(localVersion);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out PipelineRunResource obj)
	{
		obj = new PipelineRunResource();
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
							JsonTokenType.StartObject => GetOutParam<Pipeline>(ref reader, Deserialize),
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
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, RepositoryRunResources value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.All is { } localAll)
		{
			foreach (var (localAllKey, localAllValue) in localAll)
			{
				writer.WritePropertyName(localAllKey);
				Serialize(writer, localAllValue);
			}
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out RepositoryRunResources obj)
	{
		obj = new RepositoryRunResources();
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
						JsonTokenType.StartObject => GetOutParam<RepositoryRunResource>(ref reader, Deserialize),
						var unexpected => throw new InvalidOperationException($"unexpected token type for All: {unexpected} ")
					};
					obj.All.Add(lhs, rhs);
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, RepositoryRunResource value)
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
			Serialize(writer, localRepository);
		}
		if (value.Version is { } localVersion)
		{
			writer.WritePropertyName("version");
			writer.WriteStringValue(localVersion);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out RepositoryRunResource obj)
	{
		obj = new RepositoryRunResource();
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
							JsonTokenType.StartObject => GetOutParam<Respository>(ref reader, Deserialize),
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
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, Respository value)
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

	public static void Deserialize(ref Utf8JsonReader reader, out Respository obj)
	{
		obj = new Respository();
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
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, PullRequestThreadsResult value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Value is { } localValue)
		{
			writer.WritePropertyName("value");
			Serialize12(writer, localValue);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out PullRequestThreadsResult obj)
	{
		obj = new PullRequestThreadsResult();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("value"))
					{
						obj.Value = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartArray => Deserialize12(ref reader, obj.Value ?? new()),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Value: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, PullRequestThread value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Id is { } localId)
		{
			writer.WritePropertyName("id");
			writer.WriteNumberValue(localId);
		}
		if (value.IsDeleted is { } localIsDeleted)
		{
			writer.WritePropertyName("isDeleted");
			writer.WriteBooleanValue(localIsDeleted);
		}
		if (value.Comments is { } localComments)
		{
			writer.WritePropertyName("comments");
			Serialize13(writer, localComments);
		}
		if (value.Status is { } localStatus)
		{
			writer.WritePropertyName("status");
			writer.WriteStringValue(localStatus);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out PullRequestThread obj)
	{
		obj = new PullRequestThread();
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
					else if (reader.ValueTextEquals("isDeleted"))
					{
						obj.IsDeleted = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.True => reader.GetBoolean(),
							JsonTokenType.False => reader.GetBoolean(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for IsDeleted: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("comments"))
					{
						obj.Comments = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartArray => Deserialize13(ref reader, obj.Comments ?? new()),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Comments: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("status"))
					{
						obj.Status = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Status: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, PullRequestThreadComment value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Id is { } localId)
		{
			writer.WritePropertyName("id");
			writer.WriteNumberValue(localId);
		}
		if (value.Content is { } localContent)
		{
			writer.WritePropertyName("content");
			writer.WriteStringValue(localContent);
		}
		if (value.CommentType is { } localCommentType)
		{
			writer.WritePropertyName("commentType");
			writer.WriteStringValue(localCommentType);
		}
		if (value.ParentCommentId is { } localParentCommentId)
		{
			writer.WritePropertyName("parentCommentId");
			writer.WriteNumberValue(localParentCommentId);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out PullRequestThreadComment obj)
	{
		obj = new PullRequestThreadComment();
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
					else if (reader.ValueTextEquals("content"))
					{
						obj.Content = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Content: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("commentType"))
					{
						obj.CommentType = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for CommentType: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("parentCommentId"))
					{
						obj.ParentCommentId = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.Number => reader.GetInt32(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for ParentCommentId: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, ReleasesResult value)
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
			Serialize14(writer, localValue);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out ReleasesResult obj)
	{
		obj = new ReleasesResult();
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
							JsonTokenType.StartArray => Deserialize14(ref reader, obj.Value ?? new()),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Value: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, Release value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Links is { } localLinks)
		{
			writer.WritePropertyName("_links");
			Serialize(writer, localLinks);
		}
		if (value.Id is { } localId)
		{
			writer.WritePropertyName("id");
			writer.WriteNumberValue(localId);
		}
		if (value.name is { } localname)
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(localname);
		}
		if (value.status is { } localstatus)
		{
			writer.WritePropertyName("status");
			writer.WriteStringValue(localstatus);
		}
		if (value.createdOn is { } localcreatedOn)
		{
			writer.WritePropertyName("createdOn");
			writer.WriteStringValue(localcreatedOn);
		}
		if (value.createdBy is { } localcreatedBy)
		{
			writer.WritePropertyName("createdBy");
			Serialize(writer, localcreatedBy);
		}
		if (value.modifiedOn is { } localmodifiedOn)
		{
			writer.WritePropertyName("modifiedOn");
			writer.WriteStringValue(localmodifiedOn);
		}
		if (value.modifiedBy is { } localmodifiedBy)
		{
			writer.WritePropertyName("modifiedBy");
			Serialize(writer, localmodifiedBy);
		}
		if (value.createdFor is { } localcreatedFor)
		{
			writer.WritePropertyName("createdFor");
			Serialize(writer, localcreatedFor);
		}
		if (value.variables is { } localvariables)
		{
			writer.WritePropertyName("variables");
			Serialize(writer, localvariables);
		}
		if (value.variableGroups is { } localvariableGroups)
		{
			writer.WritePropertyName("variableGroups");
			Serialize15(writer, localvariableGroups);
		}
		if (value.releaseDefinition is { } localreleaseDefinition)
		{
			writer.WritePropertyName("releaseDefinition");
			Serialize(writer, localreleaseDefinition);
		}
		if (value.releaseDefinitionRevision is { } localreleaseDefinitionRevision)
		{
			writer.WritePropertyName("releaseDefinitionRevision");
			writer.WriteNumberValue(localreleaseDefinitionRevision);
		}
		if (value.description is { } localdescription)
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(localdescription);
		}
		if (value.reason is { } localreason)
		{
			writer.WritePropertyName("reason");
			writer.WriteStringValue(localreason);
		}
		if (value.releaseNameFormat is { } localreleaseNameFormat)
		{
			writer.WritePropertyName("releaseNameFormat");
			writer.WriteStringValue(localreleaseNameFormat);
		}
		if (value.keepForever is { } localkeepForever)
		{
			writer.WritePropertyName("keepForever");
			writer.WriteBooleanValue(localkeepForever);
		}
		if (value.definitionSnapshotRevision is { } localdefinitionSnapshotRevision)
		{
			writer.WritePropertyName("definitionSnapshotRevision");
			writer.WriteNumberValue(localdefinitionSnapshotRevision);
		}
		if (value.logsContainerUrl is { } locallogsContainerUrl)
		{
			writer.WritePropertyName("logsContainerUrl");
			writer.WriteStringValue(locallogsContainerUrl);
		}
		if (value.url is { } localurl)
		{
			writer.WritePropertyName("url");
			writer.WriteStringValue(localurl);
		}
		if (value.tags is { } localtags)
		{
			writer.WritePropertyName("tags");
			Serialize16(writer, localtags);
		}
		if (value.triggeringArtifactAlias is { } localtriggeringArtifactAlias)
		{
			writer.WritePropertyName("triggeringArtifactAlias");
			writer.WriteStringValue(localtriggeringArtifactAlias);
		}
		if (value.projectReference is { } localprojectReference)
		{
			writer.WritePropertyName("projectReference");
			Serialize(writer, localprojectReference);
		}
		if (value.properties is { } localproperties)
		{
			writer.WritePropertyName("properties");
			Serialize(writer, localproperties);
		}
		if (value.artifacts is { } localartifacts)
		{
			writer.WritePropertyName("artifacts");
			Serialize17(writer, localartifacts);
		}
		if (value.environments is { } localenvironments)
		{
			writer.WritePropertyName("environments");
			Serialize18(writer, localenvironments);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out Release obj)
	{
		obj = new Release();
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
							JsonTokenType.StartObject => GetOutParam<ReferenceLinks>(ref reader, Deserialize),
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
					else if (reader.ValueTextEquals("status"))
					{
						obj.status = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for status: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("createdOn"))
					{
						obj.createdOn = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for createdOn: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("createdBy"))
					{
						obj.createdBy = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GetOutParam<IdentityRef>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for createdBy: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("modifiedOn"))
					{
						obj.modifiedOn = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for modifiedOn: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("modifiedBy"))
					{
						obj.modifiedBy = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GetOutParam<IdentityRef>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for modifiedBy: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("createdFor"))
					{
						obj.createdFor = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GetOutParam<IdentityRef>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for createdFor: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("variables"))
					{
						obj.variables = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GetOutParam<Variables>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for variables: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("variableGroups"))
					{
						obj.variableGroups = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartArray => Deserialize15(ref reader, obj.variableGroups ?? new()),
							var unexpected => throw new InvalidOperationException($"unexpected token type for variableGroups: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("releaseDefinition"))
					{
						obj.releaseDefinition = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GetOutParam<ReleaseDefinition>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for releaseDefinition: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("releaseDefinitionRevision"))
					{
						obj.releaseDefinitionRevision = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.Number => reader.GetInt32(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for releaseDefinitionRevision: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("description"))
					{
						obj.description = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for description: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("reason"))
					{
						obj.reason = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for reason: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("releaseNameFormat"))
					{
						obj.releaseNameFormat = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for releaseNameFormat: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("keepForever"))
					{
						obj.keepForever = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.True => reader.GetBoolean(),
							JsonTokenType.False => reader.GetBoolean(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for keepForever: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("definitionSnapshotRevision"))
					{
						obj.definitionSnapshotRevision = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.Number => reader.GetInt32(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for definitionSnapshotRevision: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("logsContainerUrl"))
					{
						obj.logsContainerUrl = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for logsContainerUrl: {unexpected} ")
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
					else if (reader.ValueTextEquals("tags"))
					{
						obj.tags = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartArray => Deserialize16(ref reader, obj.tags ?? new()),
							var unexpected => throw new InvalidOperationException($"unexpected token type for tags: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("triggeringArtifactAlias"))
					{
						obj.triggeringArtifactAlias = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for triggeringArtifactAlias: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("projectReference"))
					{
						obj.projectReference = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GetOutParam<ProjectReference>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for projectReference: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("properties"))
					{
						obj.properties = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GetOutParam<ReleasePropertiesCollection>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for properties: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("artifacts"))
					{
						obj.artifacts = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartArray => Deserialize17(ref reader, obj.artifacts ?? new()),
							var unexpected => throw new InvalidOperationException($"unexpected token type for artifacts: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("environments"))
					{
						obj.environments = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartArray => Deserialize18(ref reader, obj.environments ?? new()),
							var unexpected => throw new InvalidOperationException($"unexpected token type for environments: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, ReleaseArtifact value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.alias is { } localalias)
		{
			writer.WritePropertyName("alias");
			writer.WriteStringValue(localalias);
		}
		if (value.definitionReference is { } localdefinitionReference)
		{
			writer.WritePropertyName("definitionReference");
			Serialize(writer, localdefinitionReference);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out ReleaseArtifact obj)
	{
		obj = new ReleaseArtifact();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("alias"))
					{
						obj.alias = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for alias: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("definitionReference"))
					{
						obj.definitionReference = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GetOutParam<ReleaseArtifactDefinitionReference>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for definitionReference: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, ReleaseArtifactDefinitionReference value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.sourceVersion is { } localsourceVersion)
		{
			writer.WritePropertyName("sourceVersion");
			Serialize(writer, localsourceVersion);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out ReleaseArtifactDefinitionReference obj)
	{
		obj = new ReleaseArtifactDefinitionReference();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("sourceVersion"))
					{
						obj.sourceVersion = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GetOutParam<IdReference>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for sourceVersion: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, ReleaseDefinitionsResult value)
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
			Serialize19(writer, localValue);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out ReleaseDefinitionsResult obj)
	{
		obj = new ReleaseDefinitionsResult();
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
							JsonTokenType.StartArray => Deserialize19(ref reader, obj.Value ?? new()),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Value: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, ReleaseDefinition value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Links is { } localLinks)
		{
			writer.WritePropertyName("_links");
			Serialize(writer, localLinks);
		}
		if (value.source is { } localsource)
		{
			writer.WritePropertyName("source");
			writer.WriteStringValue(localsource);
		}
		if (value.Revision is { } localRevision)
		{
			writer.WritePropertyName("revision");
			writer.WriteNumberValue(localRevision);
		}
		if (value.description is { } localdescription)
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(localdescription);
		}
		if (value.createdBy is { } localcreatedBy)
		{
			writer.WritePropertyName("createdBy");
			Serialize(writer, localcreatedBy);
		}
		if (value.createdOn is { } localcreatedOn)
		{
			writer.WritePropertyName("createdOn");
			writer.WriteStringValue(localcreatedOn);
		}
		if (value.modifiedBy is { } localmodifiedBy)
		{
			writer.WritePropertyName("modifiedBy");
			Serialize(writer, localmodifiedBy);
		}
		if (value.modifiedOn is { } localmodifiedOn)
		{
			writer.WritePropertyName("modifiedOn");
			writer.WriteStringValue(localmodifiedOn);
		}
		if (value.isDeleted is { } localisDeleted)
		{
			writer.WritePropertyName("isDeleted");
			writer.WriteBooleanValue(localisDeleted);
		}
		if (value.variableGroups is { } localvariableGroups)
		{
			writer.WritePropertyName("variableGroups");
			Serialize20(writer, localvariableGroups);
		}
		if (value.releaseNameFormat is { } localreleaseNameFormat)
		{
			writer.WritePropertyName("releaseNameFormat");
			writer.WriteStringValue(localreleaseNameFormat);
		}
		if (value.properties is { } localproperties)
		{
			writer.WritePropertyName("properties");
			Serialize(writer, localproperties);
		}
		if (value.Id is { } localId)
		{
			writer.WritePropertyName("id");
			writer.WriteNumberValue(localId);
		}
		if (value.name is { } localname)
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(localname);
		}
		if (value.path is { } localpath)
		{
			writer.WritePropertyName("path");
			writer.WriteStringValue(localpath);
		}
		if (value.projectReference is { } localprojectReference)
		{
			writer.WritePropertyName("projectReference");
			Serialize(writer, localprojectReference);
		}
		if (value.url is { } localurl)
		{
			writer.WritePropertyName("url");
			writer.WriteStringValue(localurl);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out ReleaseDefinition obj)
	{
		obj = new ReleaseDefinition();
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
							JsonTokenType.StartObject => GetOutParam<ReferenceLinks>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Links: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("source"))
					{
						obj.source = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for source: {unexpected} ")
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
					else if (reader.ValueTextEquals("description"))
					{
						obj.description = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for description: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("createdBy"))
					{
						obj.createdBy = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GetOutParam<IdentityRef>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for createdBy: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("createdOn"))
					{
						obj.createdOn = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for createdOn: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("modifiedBy"))
					{
						obj.modifiedBy = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GetOutParam<IdentityRef>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for modifiedBy: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("modifiedOn"))
					{
						obj.modifiedOn = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for modifiedOn: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("isDeleted"))
					{
						obj.isDeleted = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.True => reader.GetBoolean(),
							JsonTokenType.False => reader.GetBoolean(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for isDeleted: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("variableGroups"))
					{
						obj.variableGroups = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartArray => Deserialize20(ref reader, obj.variableGroups ?? new()),
							var unexpected => throw new InvalidOperationException($"unexpected token type for variableGroups: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("releaseNameFormat"))
					{
						obj.releaseNameFormat = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for releaseNameFormat: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("properties"))
					{
						obj.properties = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GetOutParam<ReleasePropertiesCollection>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for properties: {unexpected} ")
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
						obj.name = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for name: {unexpected} ")
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
					else if (reader.ValueTextEquals("projectReference"))
					{
						obj.projectReference = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GetOutParam<ProjectReference>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for projectReference: {unexpected} ")
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
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, ReleaseEnvironment value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.id is { } localid)
		{
			writer.WritePropertyName("id");
			writer.WriteNumberValue(localid);
		}
		if (value.name is { } localname)
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(localname);
		}
		if (value.status is { } localstatus)
		{
			writer.WritePropertyName("status");
			writer.WriteStringValue(localstatus);
		}
		if (value.definitionEnvironmentId is { } localdefinitionEnvironmentId)
		{
			writer.WritePropertyName("definitionEnvironmentId");
			writer.WriteNumberValue(localdefinitionEnvironmentId);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out ReleaseEnvironment obj)
	{
		obj = new ReleaseEnvironment();
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
							JsonTokenType.Number => reader.GetInt32(),
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
					else if (reader.ValueTextEquals("status"))
					{
						obj.status = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for status: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("definitionEnvironmentId"))
					{
						obj.definitionEnvironmentId = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.Number => reader.GetInt32(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for definitionEnvironmentId: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, ReleasePropertiesCollection value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out ReleasePropertiesCollection obj)
	{
		obj = new ReleasePropertiesCollection();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, IdReference value)
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
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out IdReference obj)
	{
		obj = new IdReference();
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

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, IdentityRef value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Links is { } localLinks)
		{
			writer.WritePropertyName("_links");
			Serialize(writer, localLinks);
		}
		if (value.displayName is { } localdisplayName)
		{
			writer.WritePropertyName("displayName");
			writer.WriteStringValue(localdisplayName);
		}
		if (value.url is { } localurl)
		{
			writer.WritePropertyName("url");
			writer.WriteStringValue(localurl);
		}
		if (value.id is { } localid)
		{
			writer.WritePropertyName("id");
			writer.WriteStringValue(localid);
		}
		if (value.uniqueName is { } localuniqueName)
		{
			writer.WritePropertyName("uniqueName");
			writer.WriteStringValue(localuniqueName);
		}
		if (value.imageUrl is { } localimageUrl)
		{
			writer.WritePropertyName("imageUrl");
			writer.WriteStringValue(localimageUrl);
		}
		if (value.descriptor is { } localdescriptor)
		{
			writer.WritePropertyName("descriptor");
			writer.WriteStringValue(localdescriptor);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out IdentityRef obj)
	{
		obj = new IdentityRef();
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
							JsonTokenType.StartObject => GetOutParam<ReferenceLinks>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Links: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("displayName"))
					{
						obj.displayName = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for displayName: {unexpected} ")
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
					else if (reader.ValueTextEquals("id"))
					{
						obj.id = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for id: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("uniqueName"))
					{
						obj.uniqueName = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for uniqueName: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("imageUrl"))
					{
						obj.imageUrl = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for imageUrl: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("descriptor"))
					{
						obj.descriptor = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for descriptor: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, ProjectReference value)
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
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out ProjectReference obj)
	{
		obj = new ProjectReference();
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

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, ReferenceLinks value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Self is { } localSelf)
		{
			writer.WritePropertyName("self");
			Serialize(writer, localSelf);
		}
		if (value.Web is { } localWeb)
		{
			writer.WritePropertyName("web");
			Serialize(writer, localWeb);
		}
		if (value.All is { } localAll)
		{
			foreach (var (localAllKey, localAllValue) in localAll)
			{
				writer.WritePropertyName(localAllKey);
				Serialize(writer, localAllValue);
			}
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out ReferenceLinks obj)
	{
		obj = new ReferenceLinks();
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
							JsonTokenType.StartObject => GetOutParam<ReferenceLink>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Self: {unexpected} ")
						};
						break;
					}
					else if (reader.ValueTextEquals("web"))
					{
						obj.Web = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.StartObject => GetOutParam<ReferenceLink>(ref reader, Deserialize),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Web: {unexpected} ")
						};
						break;
					}
					obj.All ??= new();
					var lhs = reader.GetString() ?? throw new NullReferenceException();
					var rhs = Next(ref reader) switch
					{
						JsonTokenType.Null => null,
						JsonTokenType.StartObject => GetOutParam<ReferenceLink>(ref reader, Deserialize),
						var unexpected => throw new InvalidOperationException($"unexpected token type for All: {unexpected} ")
					};
					obj.All.Add(lhs, rhs);
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, ReferenceLink value)
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

	public static void Deserialize(ref Utf8JsonReader reader, out ReferenceLink obj)
	{
		obj = new ReferenceLink();
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
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, Variables value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.All is { } localAll)
		{
			foreach (var (localAllKey, localAllValue) in localAll)
			{
				writer.WritePropertyName(localAllKey);
				Serialize(writer, localAllValue);
			}
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out Variables obj)
	{
		obj = new Variables();
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
						JsonTokenType.StartObject => GetOutParam<VariableValue>(ref reader, Deserialize),
						var unexpected => throw new InvalidOperationException($"unexpected token type for All: {unexpected} ")
					};
					obj.All.Add(lhs, rhs);
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, VariableValue value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Value is { } localValue)
		{
			writer.WritePropertyName("value");
			writer.WriteStringValue(localValue);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out VariableValue obj)
	{
		obj = new VariableValue();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("value"))
					{
						obj.Value = Next(ref reader) switch
						{
							JsonTokenType.Null => null,
							JsonTokenType.String => reader.GetString(),
							var unexpected => throw new InvalidOperationException($"unexpected token type for Value: {unexpected} ")
						};
						break;
					}

					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, VariableGroups value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out VariableGroups obj)
	{
		obj = new VariableGroups();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, TemplateParameters value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, out TemplateParameters obj)
	{
		obj = new TemplateParameters();
		while (true)
		{
			switch (Next(ref reader))
			{
				case JsonTokenType.EndObject:
				{
					return;
				}
				default:
				{
					reader.Skip();
					break;
				}
			}
		}
	}
	private static void Serialize0<TArray>(Utf8JsonWriter writer, TArray array) where TArray : ICollection<String>
	{
		if (array is null) { writer.WriteNullValue(); return; }
		writer.WriteStartArray();
		foreach (var item in array)
		{
			writer.WriteStringValue(item);
		}
		writer.WriteEndArray();
	}

	private static TArray Deserialize0<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<String>
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
	private static void Serialize1<TArray>(Utf8JsonWriter writer, TArray array) where TArray : ICollection<GitDiffChange>
	{
		if (array is null) { writer.WriteNullValue(); return; }
		writer.WriteStartArray();
		foreach (var item in array)
		{
			Serialize(writer, item);
		}
		writer.WriteEndArray();
	}

	private static TArray Deserialize1<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<GitDiffChange>
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
					Deserialize(ref reader, out GitDiffChange value);
					var item = value;
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
	private static void Serialize2<TArray>(Utf8JsonWriter writer, TArray array) where TArray : ICollection<String>
	{
		if (array is null) { writer.WriteNullValue(); return; }
		writer.WriteStartArray();
		foreach (var item in array)
		{
			writer.WriteStringValue(item);
		}
		writer.WriteEndArray();
	}

	private static TArray Deserialize2<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<String>
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
	private static void Serialize3<TArray>(Utf8JsonWriter writer, TArray array) where TArray : ICollection<IdentityRefWithVote>
	{
		if (array is null) { writer.WriteNullValue(); return; }
		writer.WriteStartArray();
		foreach (var item in array)
		{
			Serialize(writer, item);
		}
		writer.WriteEndArray();
	}

	private static TArray Deserialize3<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<IdentityRefWithVote>
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
					Deserialize(ref reader, out IdentityRefWithVote value);
					var item = value;
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
	private static void Serialize4<TArray>(Utf8JsonWriter writer, TArray array) where TArray : ICollection<GitPullRequest>
	{
		if (array is null) { writer.WriteNullValue(); return; }
		writer.WriteStartArray();
		foreach (var item in array)
		{
			Serialize(writer, item);
		}
		writer.WriteEndArray();
	}

	private static TArray Deserialize4<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<GitPullRequest>
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
					Deserialize(ref reader, out GitPullRequest value);
					var item = value;
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
	private static void Serialize5<TArray>(Utf8JsonWriter writer, TArray array) where TArray : ICollection<GitPullRequestStatus>
	{
		if (array is null) { writer.WriteNullValue(); return; }
		writer.WriteStartArray();
		foreach (var item in array)
		{
			Serialize(writer, item);
		}
		writer.WriteEndArray();
	}

	private static TArray Deserialize5<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<GitPullRequestStatus>
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
					Deserialize(ref reader, out GitPullRequestStatus value);
					var item = value;
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
	private static void Serialize6<TArray>(Utf8JsonWriter writer, TArray array) where TArray : ICollection<GitRef>
	{
		if (array is null) { writer.WriteNullValue(); return; }
		writer.WriteStartArray();
		foreach (var item in array)
		{
			Serialize(writer, item);
		}
		writer.WriteEndArray();
	}

	private static TArray Deserialize6<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<GitRef>
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
					Deserialize(ref reader, out GitRef value);
					var item = value;
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
	private static void Serialize7<TArray>(Utf8JsonWriter writer, TArray array) where TArray : ICollection<GitRefUpdate>
	{
		if (array is null) { writer.WriteNullValue(); return; }
		writer.WriteStartArray();
		foreach (var item in array)
		{
			Serialize(writer, item);
		}
		writer.WriteEndArray();
	}

	private static TArray Deserialize7<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<GitRefUpdate>
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
					Deserialize(ref reader, out GitRefUpdate value);
					var item = value;
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
	private static void Serialize8<TArray>(Utf8JsonWriter writer, TArray array) where TArray : ICollection<GitRefUpdateResult>
	{
		if (array is null) { writer.WriteNullValue(); return; }
		writer.WriteStartArray();
		foreach (var item in array)
		{
			Serialize(writer, item);
		}
		writer.WriteEndArray();
	}

	private static TArray Deserialize8<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<GitRefUpdateResult>
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
					Deserialize(ref reader, out GitRefUpdateResult value);
					var item = value;
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
	private static void Serialize9<TArray>(Utf8JsonWriter writer, TArray array) where TArray : ICollection<String>
	{
		if (array is null) { writer.WriteNullValue(); return; }
		writer.WriteStartArray();
		foreach (var item in array)
		{
			writer.WriteStringValue(item);
		}
		writer.WriteEndArray();
	}

	private static TArray Deserialize9<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<String>
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
	private static void Serialize10<TArray>(Utf8JsonWriter writer, TArray array) where TArray : ICollection<Pipeline>
	{
		if (array is null) { writer.WriteNullValue(); return; }
		writer.WriteStartArray();
		foreach (var item in array)
		{
			Serialize(writer, item);
		}
		writer.WriteEndArray();
	}

	private static TArray Deserialize10<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<Pipeline>
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
					Deserialize(ref reader, out Pipeline value);
					var item = value;
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
	private static void Serialize11<TArray>(Utf8JsonWriter writer, TArray array) where TArray : ICollection<Run>
	{
		if (array is null) { writer.WriteNullValue(); return; }
		writer.WriteStartArray();
		foreach (var item in array)
		{
			Serialize(writer, item);
		}
		writer.WriteEndArray();
	}

	private static TArray Deserialize11<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<Run>
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
					Deserialize(ref reader, out Run value);
					var item = value;
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
	private static void Serialize12<TArray>(Utf8JsonWriter writer, TArray array) where TArray : ICollection<PullRequestThread>
	{
		if (array is null) { writer.WriteNullValue(); return; }
		writer.WriteStartArray();
		foreach (var item in array)
		{
			Serialize(writer, item);
		}
		writer.WriteEndArray();
	}

	private static TArray Deserialize12<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<PullRequestThread>
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
					Deserialize(ref reader, out PullRequestThread value);
					var item = value;
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
	private static void Serialize13<TArray>(Utf8JsonWriter writer, TArray array) where TArray : ICollection<PullRequestThreadComment>
	{
		if (array is null) { writer.WriteNullValue(); return; }
		writer.WriteStartArray();
		foreach (var item in array)
		{
			Serialize(writer, item);
		}
		writer.WriteEndArray();
	}

	private static TArray Deserialize13<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<PullRequestThreadComment>
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
					Deserialize(ref reader, out PullRequestThreadComment value);
					var item = value;
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
	private static void Serialize14<TArray>(Utf8JsonWriter writer, TArray array) where TArray : ICollection<Release>
	{
		if (array is null) { writer.WriteNullValue(); return; }
		writer.WriteStartArray();
		foreach (var item in array)
		{
			Serialize(writer, item);
		}
		writer.WriteEndArray();
	}

	private static TArray Deserialize14<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<Release>
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
					Deserialize(ref reader, out Release value);
					var item = value;
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
	private static void Serialize15<TArray>(Utf8JsonWriter writer, TArray array) where TArray : ICollection<VariableGroups>
	{
		if (array is null) { writer.WriteNullValue(); return; }
		writer.WriteStartArray();
		foreach (var item in array)
		{
			Serialize(writer, item);
		}
		writer.WriteEndArray();
	}

	private static TArray Deserialize15<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<VariableGroups>
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
					Deserialize(ref reader, out VariableGroups value);
					var item = value;
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
	private static void Serialize16<TArray>(Utf8JsonWriter writer, TArray array) where TArray : ICollection<String>
	{
		if (array is null) { writer.WriteNullValue(); return; }
		writer.WriteStartArray();
		foreach (var item in array)
		{
			writer.WriteStringValue(item);
		}
		writer.WriteEndArray();
	}

	private static TArray Deserialize16<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<String>
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
	private static void Serialize17<TArray>(Utf8JsonWriter writer, TArray array) where TArray : ICollection<ReleaseArtifact>
	{
		if (array is null) { writer.WriteNullValue(); return; }
		writer.WriteStartArray();
		foreach (var item in array)
		{
			Serialize(writer, item);
		}
		writer.WriteEndArray();
	}

	private static TArray Deserialize17<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<ReleaseArtifact>
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
					Deserialize(ref reader, out ReleaseArtifact value);
					var item = value;
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
	private static void Serialize18<TArray>(Utf8JsonWriter writer, TArray array) where TArray : ICollection<ReleaseEnvironment>
	{
		if (array is null) { writer.WriteNullValue(); return; }
		writer.WriteStartArray();
		foreach (var item in array)
		{
			Serialize(writer, item);
		}
		writer.WriteEndArray();
	}

	private static TArray Deserialize18<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<ReleaseEnvironment>
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
					Deserialize(ref reader, out ReleaseEnvironment value);
					var item = value;
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
	private static void Serialize19<TArray>(Utf8JsonWriter writer, TArray array) where TArray : ICollection<ReleaseDefinition>
	{
		if (array is null) { writer.WriteNullValue(); return; }
		writer.WriteStartArray();
		foreach (var item in array)
		{
			Serialize(writer, item);
		}
		writer.WriteEndArray();
	}

	private static TArray Deserialize19<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<ReleaseDefinition>
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
					Deserialize(ref reader, out ReleaseDefinition value);
					var item = value;
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
	private static void Serialize20<TArray>(Utf8JsonWriter writer, TArray array) where TArray : ICollection<VariableGroups>
	{
		if (array is null) { writer.WriteNullValue(); return; }
		writer.WriteStartArray();
		foreach (var item in array)
		{
			Serialize(writer, item);
		}
		writer.WriteEndArray();
	}

	private static TArray Deserialize20<TArray>(ref Utf8JsonReader reader, TArray array) where TArray : ICollection<VariableGroups>
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
					Deserialize(ref reader, out VariableGroups value);
					var item = value;
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
public sealed partial class GitCommitRef
{
	public String? commitId { get; set; }
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
public sealed partial class GitMergeRequest
{
	public String? Comment { get; set; }
	public List<String>? Parents { get; set; }
}
public sealed partial class GitMergeResult
{
	public String? Status { get; set; }
	public int? MergeOperationId { get; set; }
	public GitMergeOperationStatusDetail? DetailedStatus { get; set; }
}
public sealed partial class GitMergeOperationStatusDetail
{
	public String? MergeCommitId { get; set; }
	public String? FailureMessage { get; set; }
}
public sealed partial class GitPerson
{
	public String? name { get; set; }
	public String? email { get; set; }
	public String? date { get; set; }
}
public sealed partial class GitPullRequest
{
	public int? PullRequestId { get; set; }
	public String? Title { get; set; }
	public String? Description { get; set; }
	public String? Status { get; set; }
	public String? SourceRefName { get; set; }
	public String? TargetRefName { get; set; }
	public GitCommitRef? LastMergeCommit { get; set; }
	public GitCommitRef? LastMergeSourceCommit { get; set; }
	public GitCommitRef? LastMergeTargetCommit { get; set; }
	public String? MergeId { get; set; }
	public String? MergeStatus { get; set; }
	public String? Url { get; set; }
	public bool? IsDraft { get; set; }
	public List<IdentityRefWithVote>? Reviewers { get; set; }
}
public sealed partial class IdentityRefWithVote
{
	public String? Id { get; set; }
	public String? DisplayName { get; set; }
	public String? UniqueName { get; set; }
	public String? Url { get; set; }
	public String? ImageUrl { get; set; }
	public bool? IsContainer { get; set; }
	public bool? IsRequired { get; set; }
	public int? Vote { get; set; }
	public String? ReviewerUrl { get; set; }
}
public sealed partial class GitPullRequestResponse
{
	public List<GitPullRequest>? Value { get; set; }
}
public sealed partial class CreateGitPullRequestStatusesRequest
{
	public int? Iteration { get; set; }
	public String? State { get; set; }
	public String? Description { get; set; }
	public GitStatusContext? Context { get; set; }
	public String? TargetUrl { get; set; }
}
public sealed partial class GitPullRequestStatus
{
	public int? Id { get; set; }
	public String? State { get; set; }
	public String? Description { get; set; }
	public GitStatusContext? Context { get; set; }
	public String? CreationDate { get; set; }
	public String? UpdatedDate { get; set; }
	public IdentityRef? CreatedBy { get; set; }
	public String? TargetUrl { get; set; }
}
public sealed partial class GitStatusContext
{
	public String? Genre { get; set; }
	public String? Name { get; set; }
}
public sealed partial class GitPullRequestStatusesResponse
{
	public int? Count { get; set; }
	public List<GitPullRequestStatus>? Value { get; set; }
}
public sealed partial class GitRef
{
	public String? Name { get; set; }
	public String? ObjectId { get; set; }
}
public sealed partial class GitRefResult
{
	public List<GitRef>? Value { get; set; }
}
public sealed partial class GitRefUpdate
{
	public String? Name { get; set; }
	public String? OldObjectId { get; set; }
	public String? NewObjectId { get; set; }
}
public sealed partial class GitRefUpdateRequest
{
	public List<GitRefUpdate>? Value { get; set; }
}
public sealed partial class GitRefUpdateResponse
{
	public List<GitRefUpdateResult>? Value { get; set; }
}
public sealed partial class GitRefUpdateResult
{
	public String? Name { get; set; }
	public String? OldObjectId { get; set; }
	public String? NewObjectId { get; set; }
	public bool? WasSuccessful { get; set; }
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
public sealed partial class PipelineRunRequest
{
	public List<String>? StagesToSkip { get; set; }
	public RunResources? Resources { get; set; }
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
	public Variables? Variables { get; set; }
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
public sealed partial class PullRequestThreadsResult
{
	public List<PullRequestThread>? Value { get; set; }
}
public sealed partial class PullRequestThread
{
	public int? Id { get; set; }
	public bool? IsDeleted { get; set; }
	public List<PullRequestThreadComment>? Comments { get; set; }
	public String? Status { get; set; }
}
public sealed partial class PullRequestThreadComment
{
	public int? Id { get; set; }
	public String? Content { get; set; }
	public String? CommentType { get; set; }
	public int? ParentCommentId { get; set; }
}
public sealed partial class ReleasesResult
{
	public int? Count { get; set; }
	public List<Release>? Value { get; set; }
}
public sealed partial class Release : ILinks
{
	public ReferenceLinks? Links { get; set; }
	public int? Id { get; set; }
	public String? name { get; set; }
	public String? status { get; set; }
	public String? createdOn { get; set; }
	public IdentityRef? createdBy { get; set; }
	public String? modifiedOn { get; set; }
	public IdentityRef? modifiedBy { get; set; }
	public IdentityRef? createdFor { get; set; }
	public Variables? variables { get; set; }
	public List<VariableGroups>? variableGroups { get; set; }
	public ReleaseDefinition? releaseDefinition { get; set; }
	public int? releaseDefinitionRevision { get; set; }
	public String? description { get; set; }
	public String? reason { get; set; }
	public String? releaseNameFormat { get; set; }
	public bool? keepForever { get; set; }
	public int? definitionSnapshotRevision { get; set; }
	public String? logsContainerUrl { get; set; }
	public String? url { get; set; }
	public List<String>? tags { get; set; }
	public String? triggeringArtifactAlias { get; set; }
	public ProjectReference? projectReference { get; set; }
	public ReleasePropertiesCollection? properties { get; set; }
	public List<ReleaseArtifact>? artifacts { get; set; }
	public List<ReleaseEnvironment>? environments { get; set; }
}
public sealed partial class ReleaseArtifact
{
	public String? alias { get; set; }
	public ReleaseArtifactDefinitionReference? definitionReference { get; set; }
}
public sealed partial class ReleaseArtifactDefinitionReference
{
	public IdReference? sourceVersion { get; set; }
}
public sealed partial class ReleaseDefinitionsResult
{
	public int? Count { get; set; }
	public List<ReleaseDefinition>? Value { get; set; }
}
public sealed partial class ReleaseDefinition : ILinks
{
	public ReferenceLinks? Links { get; set; }
	public String? source { get; set; }
	public int? Revision { get; set; }
	public String? description { get; set; }
	public IdentityRef? createdBy { get; set; }
	public String? createdOn { get; set; }
	public IdentityRef? modifiedBy { get; set; }
	public String? modifiedOn { get; set; }
	public bool? isDeleted { get; set; }
	public List<VariableGroups>? variableGroups { get; set; }
	public String? releaseNameFormat { get; set; }
	public ReleasePropertiesCollection? properties { get; set; }
	public int? Id { get; set; }
	public String? name { get; set; }
	public String? path { get; set; }
	public ProjectReference? projectReference { get; set; }
	public String? url { get; set; }
}
public sealed partial class ReleaseEnvironment
{
	public int? id { get; set; }
	public String? name { get; set; }
	public String? status { get; set; }
	public int? definitionEnvironmentId { get; set; }
}
public sealed partial class ReleasePropertiesCollection
{
}
public sealed partial class IdReference
{
	public String? id { get; set; }
	public String? name { get; set; }
}
public sealed partial class IdentityRef : ILinks
{
	public ReferenceLinks? Links { get; set; }
	public String? displayName { get; set; }
	public String? url { get; set; }
	public String? id { get; set; }
	public String? uniqueName { get; set; }
	public String? imageUrl { get; set; }
	public String? descriptor { get; set; }
}
public sealed partial class ProjectReference
{
	public String? id { get; set; }
	public String? name { get; set; }
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
public sealed partial class Variables
{
	public Dictionary<String, VariableValue>? All { get; set; }
}
public sealed partial class VariableValue
{
	public String? Value { get; set; }
}
public sealed partial class VariableGroups
{
}
public partial interface ILinks
{
	ReferenceLinks? Links { get; set; }
}
public sealed partial class TemplateParameters
{
}
