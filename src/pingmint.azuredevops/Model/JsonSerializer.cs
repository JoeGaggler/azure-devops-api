#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Pingmint.AzureDevOps.Model;

public static partial class JsonSerializer
{
	public static void Serialize(Utf8JsonWriter writer, BuildResult? value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		if (value.Reason is { } localReason)
		{
			writer.WritePropertyName("reason");
			writer.WriteStringValue(localReason);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, BuildResult obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("reason"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Reason = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Reason = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Reason: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitBranchStats? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, GitBranchStats obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("commit"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Commit = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.Commit = new(); Deserialize(ref reader, obj.Commit); break; }
						throw new InvalidOperationException($"unexpected token type for Commit: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("name"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Name = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Name = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Name: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("aheadCount"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.aheadCount = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.aheadCount = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for aheadCount: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("behindCount"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.behindCount = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.behindCount = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for behindCount: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("isBaseVersion"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.isBaseVersion = null; break; }
						if (reader.TokenType == JsonTokenType.True) { obj.isBaseVersion = true; break; }
						if (reader.TokenType == JsonTokenType.False) { obj.isBaseVersion = false; break; }
						throw new InvalidOperationException($"unexpected token type for isBaseVersion: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitCommit? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, GitCommit obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("treeId"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.treeId = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.treeId = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for treeId: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("commitId"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.commitId = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.commitId = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for commitId: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("author"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.author = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.author = new(); Deserialize(ref reader, obj.author); break; }
						throw new InvalidOperationException($"unexpected token type for author: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("committer"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.committer = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.committer = new(); Deserialize(ref reader, obj.committer); break; }
						throw new InvalidOperationException($"unexpected token type for committer: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("comment"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.comment = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.comment = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for comment: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("parents"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Parents = null; break; }
						if (reader.TokenType == JsonTokenType.StartArray) { obj.Parents = Deserialize0(ref reader, obj.Parents ?? new()); break; }
						throw new InvalidOperationException($"unexpected token type for Parents: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("url"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.url = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.url = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for url: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitCommitRef? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, GitCommitRef obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("commitId"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.commitId = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.commitId = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for commitId: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("url"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.url = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.url = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for url: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitDiffsChangeCounts? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, GitDiffsChangeCounts obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("Add"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Add = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.Add = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for Add: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("Edit"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Edit = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.Edit = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for Edit: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitDiffChange? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, GitDiffChange obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("item"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.item = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.item = new(); Deserialize(ref reader, obj.item); break; }
						throw new InvalidOperationException($"unexpected token type for item: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("changeType"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.changeType = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.changeType = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for changeType: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitDiffChangeItem? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, GitDiffChangeItem obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("objectId"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.objectId = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.objectId = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for objectId: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("originalObjectId"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.originalObjectId = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.originalObjectId = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for originalObjectId: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("gitObjectType"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.gitObjectType = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.gitObjectType = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for gitObjectType: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("commitId"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.commitId = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.commitId = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for commitId: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("path"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.path = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.path = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for path: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("isFolder"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.isFolder = null; break; }
						if (reader.TokenType == JsonTokenType.True) { obj.isFolder = true; break; }
						if (reader.TokenType == JsonTokenType.False) { obj.isFolder = false; break; }
						throw new InvalidOperationException($"unexpected token type for isFolder: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("url"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.url = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.url = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for url: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitDiffs? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, GitDiffs obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("allChangesIncluded"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.allChangesIncluded = null; break; }
						if (reader.TokenType == JsonTokenType.True) { obj.allChangesIncluded = true; break; }
						if (reader.TokenType == JsonTokenType.False) { obj.allChangesIncluded = false; break; }
						throw new InvalidOperationException($"unexpected token type for allChangesIncluded: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("changeCounts"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.changeCounts = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.changeCounts = new(); Deserialize(ref reader, obj.changeCounts); break; }
						throw new InvalidOperationException($"unexpected token type for changeCounts: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("changes"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.changes = null; break; }
						if (reader.TokenType == JsonTokenType.StartArray) { obj.changes = Deserialize1(ref reader, obj.changes ?? new()); break; }
						throw new InvalidOperationException($"unexpected token type for changes: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("commonCommit"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.commonCommit = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.commonCommit = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for commonCommit: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("baseCommit"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.baseCommit = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.baseCommit = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for baseCommit: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("targetCommit"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.targetCommit = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.targetCommit = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for targetCommit: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("aheadCount"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.aheadCount = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.aheadCount = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for aheadCount: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("behindCount"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.behindCount = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.behindCount = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for behindCount: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitMergeRequest? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, GitMergeRequest obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("comment"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Comment = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Comment = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Comment: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("parents"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Parents = null; break; }
						if (reader.TokenType == JsonTokenType.StartArray) { obj.Parents = Deserialize2(ref reader, obj.Parents ?? new()); break; }
						throw new InvalidOperationException($"unexpected token type for Parents: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitMergeResult? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, GitMergeResult obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("status"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Status = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Status = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Status: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("mergeOperationId"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.MergeOperationId = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.MergeOperationId = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for MergeOperationId: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("detailedStatus"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.DetailedStatus = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.DetailedStatus = new(); Deserialize(ref reader, obj.DetailedStatus); break; }
						throw new InvalidOperationException($"unexpected token type for DetailedStatus: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitMergeOperationStatusDetail? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, GitMergeOperationStatusDetail obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("mergeCommitId"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.MergeCommitId = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.MergeCommitId = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for MergeCommitId: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("failureMessage"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.FailureMessage = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.FailureMessage = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for FailureMessage: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitPerson? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, GitPerson obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("name"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.name = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.name = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for name: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("email"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.email = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.email = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for email: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("date"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.date = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.date = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for date: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitPullRequest? value)
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
		if (value.Repository is { } localRepository)
		{
			writer.WritePropertyName("repository");
			Serialize(writer, localRepository);
		}
		if (value.CreatedBy is { } localCreatedBy)
		{
			writer.WritePropertyName("createdBy");
			Serialize(writer, localCreatedBy);
		}
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, GitPullRequest obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("pullRequestId"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.PullRequestId = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.PullRequestId = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for PullRequestId: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("title"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Title = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Title = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Title: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("description"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Description = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Description = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Description: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("status"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Status = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Status = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Status: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("sourceRefName"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.SourceRefName = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.SourceRefName = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for SourceRefName: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("targetRefName"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.TargetRefName = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.TargetRefName = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for TargetRefName: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("lastMergeCommit"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.LastMergeCommit = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.LastMergeCommit = new(); Deserialize(ref reader, obj.LastMergeCommit); break; }
						throw new InvalidOperationException($"unexpected token type for LastMergeCommit: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("lastMergeSourceCommit"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.LastMergeSourceCommit = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.LastMergeSourceCommit = new(); Deserialize(ref reader, obj.LastMergeSourceCommit); break; }
						throw new InvalidOperationException($"unexpected token type for LastMergeSourceCommit: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("lastMergeTargetCommit"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.LastMergeTargetCommit = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.LastMergeTargetCommit = new(); Deserialize(ref reader, obj.LastMergeTargetCommit); break; }
						throw new InvalidOperationException($"unexpected token type for LastMergeTargetCommit: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("mergeId"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.MergeId = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.MergeId = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for MergeId: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("mergeStatus"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.MergeStatus = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.MergeStatus = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for MergeStatus: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("url"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Url = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Url = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Url: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("isDraft"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.IsDraft = null; break; }
						if (reader.TokenType == JsonTokenType.True) { obj.IsDraft = true; break; }
						if (reader.TokenType == JsonTokenType.False) { obj.IsDraft = false; break; }
						throw new InvalidOperationException($"unexpected token type for IsDraft: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("reviewers"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Reviewers = null; break; }
						if (reader.TokenType == JsonTokenType.StartArray) { obj.Reviewers = Deserialize3(ref reader, obj.Reviewers ?? new()); break; }
						throw new InvalidOperationException($"unexpected token type for Reviewers: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("repository"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Repository = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.Repository = new(); Deserialize(ref reader, obj.Repository); break; }
						throw new InvalidOperationException($"unexpected token type for Repository: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("createdBy"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.CreatedBy = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.CreatedBy = new(); Deserialize(ref reader, obj.CreatedBy); break; }
						throw new InvalidOperationException($"unexpected token type for CreatedBy: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, IdentityRefWithVote? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, IdentityRefWithVote obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("id"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Id = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Id = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Id: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("displayName"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.DisplayName = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.DisplayName = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for DisplayName: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("uniqueName"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.UniqueName = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.UniqueName = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for UniqueName: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("url"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Url = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Url = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Url: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("imageUrl"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.ImageUrl = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.ImageUrl = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for ImageUrl: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("isContainer"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.IsContainer = null; break; }
						if (reader.TokenType == JsonTokenType.True) { obj.IsContainer = true; break; }
						if (reader.TokenType == JsonTokenType.False) { obj.IsContainer = false; break; }
						throw new InvalidOperationException($"unexpected token type for IsContainer: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("isRequired"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.IsRequired = null; break; }
						if (reader.TokenType == JsonTokenType.True) { obj.IsRequired = true; break; }
						if (reader.TokenType == JsonTokenType.False) { obj.IsRequired = false; break; }
						throw new InvalidOperationException($"unexpected token type for IsRequired: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("vote"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Vote = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.Vote = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for Vote: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("reviewerUrl"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.ReviewerUrl = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.ReviewerUrl = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for ReviewerUrl: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitPullRequestResponse? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, GitPullRequestResponse obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("value"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Value = null; break; }
						if (reader.TokenType == JsonTokenType.StartArray) { obj.Value = Deserialize4(ref reader, obj.Value ?? new()); break; }
						throw new InvalidOperationException($"unexpected token type for Value: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, CreateGitPullRequestStatusesRequest? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, CreateGitPullRequestStatusesRequest obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("iteration"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Iteration = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.Iteration = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for Iteration: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("state"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.State = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.State = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for State: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("description"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Description = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Description = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Description: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("context"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Context = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.Context = new(); Deserialize(ref reader, obj.Context); break; }
						throw new InvalidOperationException($"unexpected token type for Context: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("targetUrl"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.TargetUrl = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.TargetUrl = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for TargetUrl: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitPullRequestStatus? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, GitPullRequestStatus obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("id"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Id = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.Id = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for Id: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("state"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.State = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.State = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for State: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("description"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Description = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Description = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Description: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("context"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Context = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.Context = new(); Deserialize(ref reader, obj.Context); break; }
						throw new InvalidOperationException($"unexpected token type for Context: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("creationDate"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.CreationDate = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.CreationDate = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for CreationDate: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("updatedDate"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.UpdatedDate = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.UpdatedDate = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for UpdatedDate: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("createdBy"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.CreatedBy = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.CreatedBy = new(); Deserialize(ref reader, obj.CreatedBy); break; }
						throw new InvalidOperationException($"unexpected token type for CreatedBy: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("targetUrl"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.TargetUrl = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.TargetUrl = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for TargetUrl: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitStatusContext? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, GitStatusContext obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("genre"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Genre = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Genre = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Genre: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("name"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Name = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Name = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Name: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitPullRequestStatusesResponse? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, GitPullRequestStatusesResponse obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("count"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Count = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.Count = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for Count: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("value"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Value = null; break; }
						if (reader.TokenType == JsonTokenType.StartArray) { obj.Value = Deserialize5(ref reader, obj.Value ?? new()); break; }
						throw new InvalidOperationException($"unexpected token type for Value: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitRef? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, GitRef obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("name"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Name = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Name = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Name: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("objectId"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.ObjectId = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.ObjectId = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for ObjectId: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitRefResult? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, GitRefResult obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("value"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Value = null; break; }
						if (reader.TokenType == JsonTokenType.StartArray) { obj.Value = Deserialize6(ref reader, obj.Value ?? new()); break; }
						throw new InvalidOperationException($"unexpected token type for Value: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitRefUpdate? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, GitRefUpdate obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("name"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Name = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Name = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Name: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("oldObjectId"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.OldObjectId = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.OldObjectId = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for OldObjectId: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("newObjectId"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.NewObjectId = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.NewObjectId = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for NewObjectId: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitRefUpdateRequest? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, GitRefUpdateRequest obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("value"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Value = null; break; }
						if (reader.TokenType == JsonTokenType.StartArray) { obj.Value = Deserialize7(ref reader, obj.Value ?? new()); break; }
						throw new InvalidOperationException($"unexpected token type for Value: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitRefUpdateResponse? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, GitRefUpdateResponse obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("value"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Value = null; break; }
						if (reader.TokenType == JsonTokenType.StartArray) { obj.Value = Deserialize8(ref reader, obj.Value ?? new()); break; }
						throw new InvalidOperationException($"unexpected token type for Value: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitRefUpdateResult? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, GitRefUpdateResult obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("name"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Name = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Name = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Name: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("oldObjectId"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.OldObjectId = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.OldObjectId = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for OldObjectId: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("newObjectId"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.NewObjectId = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.NewObjectId = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for NewObjectId: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("success"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.WasSuccessful = null; break; }
						if (reader.TokenType == JsonTokenType.True) { obj.WasSuccessful = true; break; }
						if (reader.TokenType == JsonTokenType.False) { obj.WasSuccessful = false; break; }
						throw new InvalidOperationException($"unexpected token type for WasSuccessful: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, GitRepository? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, GitRepository obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("_links"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Links = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.Links = new(); Deserialize(ref reader, obj.Links); break; }
						throw new InvalidOperationException($"unexpected token type for Links: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("defaultBranch"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.DefaultBranch = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.DefaultBranch = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for DefaultBranch: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("id"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Id = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Id = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Id: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("isDisabled"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.isDisabled = null; break; }
						if (reader.TokenType == JsonTokenType.True) { obj.isDisabled = true; break; }
						if (reader.TokenType == JsonTokenType.False) { obj.isDisabled = false; break; }
						throw new InvalidOperationException($"unexpected token type for isDisabled: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("name"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Name = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Name = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Name: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("project"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Project = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.Project = new(); Deserialize(ref reader, obj.Project); break; }
						throw new InvalidOperationException($"unexpected token type for Project: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("remoteUrl"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.remoteUrl = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.remoteUrl = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for remoteUrl: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("size"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Size = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.Size = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for Size: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("sshUrl"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.sshUrl = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.sshUrl = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for sshUrl: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("url"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Url = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Url = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Url: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("webUrl"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.webUrl = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.webUrl = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for webUrl: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, PipelineRunRequest? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, PipelineRunRequest obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("stagesToSkip"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.StagesToSkip = null; break; }
						if (reader.TokenType == JsonTokenType.StartArray) { obj.StagesToSkip = Deserialize9(ref reader, obj.StagesToSkip ?? new()); break; }
						throw new InvalidOperationException($"unexpected token type for StagesToSkip: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("resources"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Resources = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.Resources = new(); Deserialize(ref reader, obj.Resources); break; }
						throw new InvalidOperationException($"unexpected token type for Resources: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, PipelinesResult? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, PipelinesResult obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("count"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Count = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.Count = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for Count: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("value"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Value = null; break; }
						if (reader.TokenType == JsonTokenType.StartArray) { obj.Value = Deserialize10(ref reader, obj.Value ?? new()); break; }
						throw new InvalidOperationException($"unexpected token type for Value: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, Pipeline? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, Pipeline obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("_links"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Links = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.Links = new(); Deserialize(ref reader, obj.Links); break; }
						throw new InvalidOperationException($"unexpected token type for Links: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("id"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Id = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.Id = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for Id: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("folder"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Folder = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Folder = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Folder: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("name"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Name = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Name = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Name: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("revision"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Revision = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.Revision = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for Revision: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("url"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Url = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Url = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Url: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, Project? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, Project obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("id"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Id = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Id = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Id: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("name"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Name = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Name = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Name: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("url"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Url = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Url = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Url: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("state"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.State = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.State = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for State: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("revision"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Revision = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.Revision = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for Revision: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("visibility"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Visibility = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Visibility = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Visibility: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("lastUpdateTime"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.LastUpdateTime = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.LastUpdateTime = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for LastUpdateTime: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, RunsResult? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, RunsResult obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("count"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Count = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.Count = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for Count: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("value"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Value = null; break; }
						if (reader.TokenType == JsonTokenType.StartArray) { obj.Value = Deserialize11(ref reader, obj.Value ?? new()); break; }
						throw new InvalidOperationException($"unexpected token type for Value: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, Run? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, Run obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("_links"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Links = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.Links = new(); Deserialize(ref reader, obj.Links); break; }
						throw new InvalidOperationException($"unexpected token type for Links: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("createdDate"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.CreatedDate = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.CreatedDate = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for CreatedDate: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("finishedDate"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.FinishedDate = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.FinishedDate = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for FinishedDate: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("id"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Id = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.Id = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for Id: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("name"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Name = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Name = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Name: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("pipeline"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Pipeline = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.Pipeline = new(); Deserialize(ref reader, obj.Pipeline); break; }
						throw new InvalidOperationException($"unexpected token type for Pipeline: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("state"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.State = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.State = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for State: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("resources"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Resources = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.Resources = new(); Deserialize(ref reader, obj.Resources); break; }
						throw new InvalidOperationException($"unexpected token type for Resources: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("result"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Result = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Result = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Result: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("templateParameters"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.TemplateParameters = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.TemplateParameters = new(); Deserialize(ref reader, obj.TemplateParameters); break; }
						throw new InvalidOperationException($"unexpected token type for TemplateParameters: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("url"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Url = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Url = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Url: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("variables"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Variables = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.Variables = new(); Deserialize(ref reader, obj.Variables); break; }
						throw new InvalidOperationException($"unexpected token type for Variables: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, RunResources? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, RunResources obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("pipelines"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Pipelines = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.Pipelines = new(); Deserialize(ref reader, obj.Pipelines); break; }
						throw new InvalidOperationException($"unexpected token type for Pipelines: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("repositories"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Repositories = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.Repositories = new(); Deserialize(ref reader, obj.Repositories); break; }
						throw new InvalidOperationException($"unexpected token type for Repositories: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, PipelineRunResources? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, PipelineRunResources obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					obj.All ??= new();
					var lhs = reader.GetString() ?? throw new NullReferenceException();
					if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
					PipelineRunResource rhs;
					if (reader.TokenType == JsonTokenType.Null) { break; }
					else if (reader.TokenType == JsonTokenType.StartObject) { rhs = new(); Deserialize(ref reader, rhs); }
					else throw new InvalidOperationException($"unexpected token type for All: {reader.TokenType} ");
					obj.All.Add(lhs, rhs);
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, PipelineRunResource? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, PipelineRunResource obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("pipeline"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Pipeline = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.Pipeline = new(); Deserialize(ref reader, obj.Pipeline); break; }
						throw new InvalidOperationException($"unexpected token type for Pipeline: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("version"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Version = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Version = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Version: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, RepositoryRunResources? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, RepositoryRunResources obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					obj.All ??= new();
					var lhs = reader.GetString() ?? throw new NullReferenceException();
					if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
					RepositoryRunResource rhs;
					if (reader.TokenType == JsonTokenType.Null) { break; }
					else if (reader.TokenType == JsonTokenType.StartObject) { rhs = new(); Deserialize(ref reader, rhs); }
					else throw new InvalidOperationException($"unexpected token type for All: {reader.TokenType} ");
					obj.All.Add(lhs, rhs);
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, RepositoryRunResource? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, RepositoryRunResource obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("refName"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.RefName = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.RefName = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for RefName: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("repository"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Repository = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.Repository = new(); Deserialize(ref reader, obj.Repository); break; }
						throw new InvalidOperationException($"unexpected token type for Repository: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("version"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Version = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Version = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Version: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, Respository? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, Respository obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("id"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Id = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Id = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Id: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("type"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Type = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Type = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Type: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, PullRequestThreadsResult? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, PullRequestThreadsResult obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("value"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Value = null; break; }
						if (reader.TokenType == JsonTokenType.StartArray) { obj.Value = Deserialize12(ref reader, obj.Value ?? new()); break; }
						throw new InvalidOperationException($"unexpected token type for Value: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, PullRequestThread? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, PullRequestThread obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("id"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Id = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.Id = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for Id: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("isDeleted"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.IsDeleted = null; break; }
						if (reader.TokenType == JsonTokenType.True) { obj.IsDeleted = true; break; }
						if (reader.TokenType == JsonTokenType.False) { obj.IsDeleted = false; break; }
						throw new InvalidOperationException($"unexpected token type for IsDeleted: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("comments"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Comments = null; break; }
						if (reader.TokenType == JsonTokenType.StartArray) { obj.Comments = Deserialize13(ref reader, obj.Comments ?? new()); break; }
						throw new InvalidOperationException($"unexpected token type for Comments: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("status"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Status = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Status = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Status: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, PullRequestThreadComment? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, PullRequestThreadComment obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("id"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Id = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.Id = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for Id: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("content"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Content = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Content = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Content: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("commentType"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.CommentType = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.CommentType = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for CommentType: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("parentCommentId"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.ParentCommentId = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.ParentCommentId = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for ParentCommentId: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, ReleasesResult? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, ReleasesResult obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("count"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Count = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.Count = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for Count: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("value"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Value = null; break; }
						if (reader.TokenType == JsonTokenType.StartArray) { obj.Value = Deserialize14(ref reader, obj.Value ?? new()); break; }
						throw new InvalidOperationException($"unexpected token type for Value: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, Release? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, Release obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("_links"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Links = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.Links = new(); Deserialize(ref reader, obj.Links); break; }
						throw new InvalidOperationException($"unexpected token type for Links: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("id"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Id = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.Id = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for Id: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("name"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.name = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.name = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for name: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("status"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.status = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.status = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for status: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("createdOn"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.createdOn = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.createdOn = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for createdOn: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("createdBy"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.createdBy = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.createdBy = new(); Deserialize(ref reader, obj.createdBy); break; }
						throw new InvalidOperationException($"unexpected token type for createdBy: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("modifiedOn"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.modifiedOn = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.modifiedOn = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for modifiedOn: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("modifiedBy"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.modifiedBy = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.modifiedBy = new(); Deserialize(ref reader, obj.modifiedBy); break; }
						throw new InvalidOperationException($"unexpected token type for modifiedBy: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("createdFor"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.createdFor = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.createdFor = new(); Deserialize(ref reader, obj.createdFor); break; }
						throw new InvalidOperationException($"unexpected token type for createdFor: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("variables"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.variables = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.variables = new(); Deserialize(ref reader, obj.variables); break; }
						throw new InvalidOperationException($"unexpected token type for variables: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("variableGroups"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.variableGroups = null; break; }
						if (reader.TokenType == JsonTokenType.StartArray) { obj.variableGroups = Deserialize15(ref reader, obj.variableGroups ?? new()); break; }
						throw new InvalidOperationException($"unexpected token type for variableGroups: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("releaseDefinition"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.releaseDefinition = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.releaseDefinition = new(); Deserialize(ref reader, obj.releaseDefinition); break; }
						throw new InvalidOperationException($"unexpected token type for releaseDefinition: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("releaseDefinitionRevision"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.releaseDefinitionRevision = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.releaseDefinitionRevision = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for releaseDefinitionRevision: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("description"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.description = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.description = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for description: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("reason"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.reason = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.reason = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for reason: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("releaseNameFormat"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.releaseNameFormat = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.releaseNameFormat = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for releaseNameFormat: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("keepForever"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.keepForever = null; break; }
						if (reader.TokenType == JsonTokenType.True) { obj.keepForever = true; break; }
						if (reader.TokenType == JsonTokenType.False) { obj.keepForever = false; break; }
						throw new InvalidOperationException($"unexpected token type for keepForever: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("definitionSnapshotRevision"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.definitionSnapshotRevision = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.definitionSnapshotRevision = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for definitionSnapshotRevision: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("logsContainerUrl"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.logsContainerUrl = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.logsContainerUrl = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for logsContainerUrl: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("url"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.url = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.url = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for url: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("tags"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.tags = null; break; }
						if (reader.TokenType == JsonTokenType.StartArray) { obj.tags = Deserialize16(ref reader, obj.tags ?? new()); break; }
						throw new InvalidOperationException($"unexpected token type for tags: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("triggeringArtifactAlias"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.triggeringArtifactAlias = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.triggeringArtifactAlias = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for triggeringArtifactAlias: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("projectReference"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.projectReference = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.projectReference = new(); Deserialize(ref reader, obj.projectReference); break; }
						throw new InvalidOperationException($"unexpected token type for projectReference: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("properties"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.properties = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.properties = new(); Deserialize(ref reader, obj.properties); break; }
						throw new InvalidOperationException($"unexpected token type for properties: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("artifacts"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.artifacts = null; break; }
						if (reader.TokenType == JsonTokenType.StartArray) { obj.artifacts = Deserialize17(ref reader, obj.artifacts ?? new()); break; }
						throw new InvalidOperationException($"unexpected token type for artifacts: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("environments"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.environments = null; break; }
						if (reader.TokenType == JsonTokenType.StartArray) { obj.environments = Deserialize18(ref reader, obj.environments ?? new()); break; }
						throw new InvalidOperationException($"unexpected token type for environments: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, ReleaseArtifact? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, ReleaseArtifact obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("alias"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.alias = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.alias = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for alias: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("definitionReference"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.definitionReference = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.definitionReference = new(); Deserialize(ref reader, obj.definitionReference); break; }
						throw new InvalidOperationException($"unexpected token type for definitionReference: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, ReleaseArtifactDefinitionReference? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, ReleaseArtifactDefinitionReference obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("sourceVersion"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.sourceVersion = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.sourceVersion = new(); Deserialize(ref reader, obj.sourceVersion); break; }
						throw new InvalidOperationException($"unexpected token type for sourceVersion: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, ReleaseDefinitionsResult? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, ReleaseDefinitionsResult obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("count"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Count = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.Count = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for Count: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("value"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Value = null; break; }
						if (reader.TokenType == JsonTokenType.StartArray) { obj.Value = Deserialize19(ref reader, obj.Value ?? new()); break; }
						throw new InvalidOperationException($"unexpected token type for Value: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, ReleaseDefinition? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, ReleaseDefinition obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("_links"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Links = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.Links = new(); Deserialize(ref reader, obj.Links); break; }
						throw new InvalidOperationException($"unexpected token type for Links: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("source"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.source = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.source = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for source: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("revision"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Revision = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.Revision = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for Revision: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("description"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.description = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.description = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for description: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("createdBy"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.createdBy = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.createdBy = new(); Deserialize(ref reader, obj.createdBy); break; }
						throw new InvalidOperationException($"unexpected token type for createdBy: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("createdOn"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.createdOn = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.createdOn = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for createdOn: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("modifiedBy"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.modifiedBy = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.modifiedBy = new(); Deserialize(ref reader, obj.modifiedBy); break; }
						throw new InvalidOperationException($"unexpected token type for modifiedBy: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("modifiedOn"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.modifiedOn = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.modifiedOn = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for modifiedOn: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("isDeleted"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.isDeleted = null; break; }
						if (reader.TokenType == JsonTokenType.True) { obj.isDeleted = true; break; }
						if (reader.TokenType == JsonTokenType.False) { obj.isDeleted = false; break; }
						throw new InvalidOperationException($"unexpected token type for isDeleted: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("variableGroups"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.variableGroups = null; break; }
						if (reader.TokenType == JsonTokenType.StartArray) { obj.variableGroups = Deserialize20(ref reader, obj.variableGroups ?? new()); break; }
						throw new InvalidOperationException($"unexpected token type for variableGroups: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("releaseNameFormat"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.releaseNameFormat = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.releaseNameFormat = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for releaseNameFormat: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("properties"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.properties = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.properties = new(); Deserialize(ref reader, obj.properties); break; }
						throw new InvalidOperationException($"unexpected token type for properties: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("id"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Id = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.Id = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for Id: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("name"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.name = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.name = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for name: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("path"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.path = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.path = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for path: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("projectReference"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.projectReference = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.projectReference = new(); Deserialize(ref reader, obj.projectReference); break; }
						throw new InvalidOperationException($"unexpected token type for projectReference: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("url"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.url = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.url = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for url: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, ReleaseEnvironment? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, ReleaseEnvironment obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("id"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.id = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.id = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for id: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("name"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.name = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.name = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for name: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("status"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.status = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.status = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for status: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("definitionEnvironmentId"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.definitionEnvironmentId = null; break; }
						if (reader.TokenType == JsonTokenType.Number) { obj.definitionEnvironmentId = reader.GetInt32(); break; }
						throw new InvalidOperationException($"unexpected token type for definitionEnvironmentId: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, ReleasePropertiesCollection? value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, ReleasePropertiesCollection obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, IdReference? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, IdReference obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("id"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.id = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.id = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for id: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("name"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.name = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.name = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for name: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, IdentityRef? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, IdentityRef obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("_links"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Links = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.Links = new(); Deserialize(ref reader, obj.Links); break; }
						throw new InvalidOperationException($"unexpected token type for Links: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("displayName"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.displayName = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.displayName = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for displayName: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("url"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.url = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.url = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for url: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("id"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.id = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.id = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for id: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("uniqueName"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.uniqueName = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.uniqueName = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for uniqueName: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("imageUrl"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.imageUrl = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.imageUrl = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for imageUrl: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("descriptor"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.descriptor = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.descriptor = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for descriptor: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, ProjectReference? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, ProjectReference obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("id"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.id = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.id = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for id: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("name"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.name = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.name = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for name: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, ReferenceLinks? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, ReferenceLinks obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("self"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Self = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.Self = new(); Deserialize(ref reader, obj.Self); break; }
						throw new InvalidOperationException($"unexpected token type for Self: {reader.TokenType} ");
					}
					else if (reader.ValueTextEquals("web"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Web = null; break; }
						if (reader.TokenType == JsonTokenType.StartObject) { obj.Web = new(); Deserialize(ref reader, obj.Web); break; }
						throw new InvalidOperationException($"unexpected token type for Web: {reader.TokenType} ");
					}
					obj.All ??= new();
					var lhs = reader.GetString() ?? throw new NullReferenceException();
					if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
					ReferenceLink rhs;
					if (reader.TokenType == JsonTokenType.Null) { break; }
					else if (reader.TokenType == JsonTokenType.StartObject) { rhs = new(); Deserialize(ref reader, rhs); }
					else throw new InvalidOperationException($"unexpected token type for All: {reader.TokenType} ");
					obj.All.Add(lhs, rhs);
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, ReferenceLink? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, ReferenceLink obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("href"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Href = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Href = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Href: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, Variables? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, Variables obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					obj.All ??= new();
					var lhs = reader.GetString() ?? throw new NullReferenceException();
					if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
					VariableValue rhs;
					if (reader.TokenType == JsonTokenType.Null) { break; }
					else if (reader.TokenType == JsonTokenType.StartObject) { rhs = new(); Deserialize(ref reader, rhs); }
					else throw new InvalidOperationException($"unexpected token type for All: {reader.TokenType} ");
					obj.All.Add(lhs, rhs);
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, VariableValue? value)
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

	public static void Deserialize(ref Utf8JsonReader reader, VariableValue obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.PropertyName:
				{
					if (reader.ValueTextEquals("value"))
					{
						if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
						if (reader.TokenType == JsonTokenType.Null) { obj.Value = null; break; }
						if (reader.TokenType == JsonTokenType.String) { obj.Value = reader.GetString()!; break; }
						throw new InvalidOperationException($"unexpected token type for Value: {reader.TokenType} ");
					}

					reader.Skip();
					reader.Skip();
					break;
				}
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, VariableGroups? value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, VariableGroups obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
			}
		}
	}
	public static void Serialize(Utf8JsonWriter writer, TemplateParameters? value)
	{
		if (value is null) { writer.WriteNullValue(); return; }
		writer.WriteStartObject();
		writer.WriteEndObject();
	}

	public static void Deserialize(ref Utf8JsonReader reader, TemplateParameters obj)
	{
		while (true)
		{
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.EndObject: { return; }
				default: { reader.Skip(); break; }
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
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.Null: { reader.Skip(); break; }
				case JsonTokenType.String:
				{
					var item = reader.GetString();
					array.Add(item!);
					break;
				}
				case JsonTokenType.EndArray: { return array; }
				default: { reader.Skip(); break; }
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
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.Null: { reader.Skip(); break; }
				case JsonTokenType.StartObject:
				{
					GitDiffChange item = new();
					Deserialize(ref reader, item);
					array.Add(item);
					break;
				}
				case JsonTokenType.EndArray: { return array; }
				default: { reader.Skip(); break; }
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
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.Null: { reader.Skip(); break; }
				case JsonTokenType.String:
				{
					var item = reader.GetString();
					array.Add(item!);
					break;
				}
				case JsonTokenType.EndArray: { return array; }
				default: { reader.Skip(); break; }
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
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.Null: { reader.Skip(); break; }
				case JsonTokenType.StartObject:
				{
					IdentityRefWithVote item = new();
					Deserialize(ref reader, item);
					array.Add(item);
					break;
				}
				case JsonTokenType.EndArray: { return array; }
				default: { reader.Skip(); break; }
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
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.Null: { reader.Skip(); break; }
				case JsonTokenType.StartObject:
				{
					GitPullRequest item = new();
					Deserialize(ref reader, item);
					array.Add(item);
					break;
				}
				case JsonTokenType.EndArray: { return array; }
				default: { reader.Skip(); break; }
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
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.Null: { reader.Skip(); break; }
				case JsonTokenType.StartObject:
				{
					GitPullRequestStatus item = new();
					Deserialize(ref reader, item);
					array.Add(item);
					break;
				}
				case JsonTokenType.EndArray: { return array; }
				default: { reader.Skip(); break; }
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
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.Null: { reader.Skip(); break; }
				case JsonTokenType.StartObject:
				{
					GitRef item = new();
					Deserialize(ref reader, item);
					array.Add(item);
					break;
				}
				case JsonTokenType.EndArray: { return array; }
				default: { reader.Skip(); break; }
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
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.Null: { reader.Skip(); break; }
				case JsonTokenType.StartObject:
				{
					GitRefUpdate item = new();
					Deserialize(ref reader, item);
					array.Add(item);
					break;
				}
				case JsonTokenType.EndArray: { return array; }
				default: { reader.Skip(); break; }
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
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.Null: { reader.Skip(); break; }
				case JsonTokenType.StartObject:
				{
					GitRefUpdateResult item = new();
					Deserialize(ref reader, item);
					array.Add(item);
					break;
				}
				case JsonTokenType.EndArray: { return array; }
				default: { reader.Skip(); break; }
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
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.Null: { reader.Skip(); break; }
				case JsonTokenType.String:
				{
					var item = reader.GetString();
					array.Add(item!);
					break;
				}
				case JsonTokenType.EndArray: { return array; }
				default: { reader.Skip(); break; }
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
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.Null: { reader.Skip(); break; }
				case JsonTokenType.StartObject:
				{
					Pipeline item = new();
					Deserialize(ref reader, item);
					array.Add(item);
					break;
				}
				case JsonTokenType.EndArray: { return array; }
				default: { reader.Skip(); break; }
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
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.Null: { reader.Skip(); break; }
				case JsonTokenType.StartObject:
				{
					Run item = new();
					Deserialize(ref reader, item);
					array.Add(item);
					break;
				}
				case JsonTokenType.EndArray: { return array; }
				default: { reader.Skip(); break; }
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
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.Null: { reader.Skip(); break; }
				case JsonTokenType.StartObject:
				{
					PullRequestThread item = new();
					Deserialize(ref reader, item);
					array.Add(item);
					break;
				}
				case JsonTokenType.EndArray: { return array; }
				default: { reader.Skip(); break; }
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
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.Null: { reader.Skip(); break; }
				case JsonTokenType.StartObject:
				{
					PullRequestThreadComment item = new();
					Deserialize(ref reader, item);
					array.Add(item);
					break;
				}
				case JsonTokenType.EndArray: { return array; }
				default: { reader.Skip(); break; }
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
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.Null: { reader.Skip(); break; }
				case JsonTokenType.StartObject:
				{
					Release item = new();
					Deserialize(ref reader, item);
					array.Add(item);
					break;
				}
				case JsonTokenType.EndArray: { return array; }
				default: { reader.Skip(); break; }
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
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.Null: { reader.Skip(); break; }
				case JsonTokenType.StartObject:
				{
					VariableGroups item = new();
					Deserialize(ref reader, item);
					array.Add(item);
					break;
				}
				case JsonTokenType.EndArray: { return array; }
				default: { reader.Skip(); break; }
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
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.Null: { reader.Skip(); break; }
				case JsonTokenType.String:
				{
					var item = reader.GetString();
					array.Add(item!);
					break;
				}
				case JsonTokenType.EndArray: { return array; }
				default: { reader.Skip(); break; }
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
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.Null: { reader.Skip(); break; }
				case JsonTokenType.StartObject:
				{
					ReleaseArtifact item = new();
					Deserialize(ref reader, item);
					array.Add(item);
					break;
				}
				case JsonTokenType.EndArray: { return array; }
				default: { reader.Skip(); break; }
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
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.Null: { reader.Skip(); break; }
				case JsonTokenType.StartObject:
				{
					ReleaseEnvironment item = new();
					Deserialize(ref reader, item);
					array.Add(item);
					break;
				}
				case JsonTokenType.EndArray: { return array; }
				default: { reader.Skip(); break; }
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
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.Null: { reader.Skip(); break; }
				case JsonTokenType.StartObject:
				{
					ReleaseDefinition item = new();
					Deserialize(ref reader, item);
					array.Add(item);
					break;
				}
				case JsonTokenType.EndArray: { return array; }
				default: { reader.Skip(); break; }
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
			if (!reader.Read()) throw new InvalidOperationException("Unable to read next token from Utf8JsonReader");
			switch (reader.TokenType)
			{
				case JsonTokenType.Null: { reader.Skip(); break; }
				case JsonTokenType.StartObject:
				{
					VariableGroups item = new();
					Deserialize(ref reader, item);
					array.Add(item);
					break;
				}
				case JsonTokenType.EndArray: { return array; }
				default: { reader.Skip(); break; }
			}
		}
	}
}
public sealed partial record class BuildResult
{
	public String? Reason { get; set; }
}
public sealed partial record class GitBranchStats
{
	public GitCommit? Commit { get; set; }
	public String? Name { get; set; }
	public int? aheadCount { get; set; }
	public int? behindCount { get; set; }
	public bool? isBaseVersion { get; set; }
}
public sealed partial record class GitCommit
{
	public String? treeId { get; set; }
	public String? commitId { get; set; }
	public GitPerson? author { get; set; }
	public GitPerson? committer { get; set; }
	public String? comment { get; set; }
	public List<String>? Parents { get; set; }
	public String? url { get; set; }
}
public sealed partial record class GitCommitRef
{
	public String? commitId { get; set; }
	public String? url { get; set; }
}
public sealed partial record class GitDiffsChangeCounts
{
	public int? Add { get; set; }
	public int? Edit { get; set; }
}
public sealed partial record class GitDiffChange
{
	public GitDiffChangeItem? item { get; set; }
	public String? changeType { get; set; }
}
public sealed partial record class GitDiffChangeItem
{
	public String? objectId { get; set; }
	public String? originalObjectId { get; set; }
	public String? gitObjectType { get; set; }
	public String? commitId { get; set; }
	public String? path { get; set; }
	public bool? isFolder { get; set; }
	public String? url { get; set; }
}
public sealed partial record class GitDiffs
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
public sealed partial record class GitMergeRequest
{
	public String? Comment { get; set; }
	public List<String>? Parents { get; set; }
}
public sealed partial record class GitMergeResult
{
	public String? Status { get; set; }
	public int? MergeOperationId { get; set; }
	public GitMergeOperationStatusDetail? DetailedStatus { get; set; }
}
public sealed partial record class GitMergeOperationStatusDetail
{
	public String? MergeCommitId { get; set; }
	public String? FailureMessage { get; set; }
}
public sealed partial record class GitPerson
{
	public String? name { get; set; }
	public String? email { get; set; }
	public String? date { get; set; }
}
public sealed partial record class GitPullRequest
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
	public GitRepository? Repository { get; set; }
	public IdentityRef? CreatedBy { get; set; }
}
public sealed partial record class IdentityRefWithVote
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
public sealed partial record class GitPullRequestResponse
{
	public List<GitPullRequest>? Value { get; set; }
}
public sealed partial record class CreateGitPullRequestStatusesRequest
{
	public int? Iteration { get; set; }
	public String? State { get; set; }
	public String? Description { get; set; }
	public GitStatusContext? Context { get; set; }
	public String? TargetUrl { get; set; }
}
public sealed partial record class GitPullRequestStatus
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
public sealed partial record class GitStatusContext
{
	public String? Genre { get; set; }
	public String? Name { get; set; }
}
public sealed partial record class GitPullRequestStatusesResponse
{
	public int? Count { get; set; }
	public List<GitPullRequestStatus>? Value { get; set; }
}
public sealed partial record class GitRef
{
	public String? Name { get; set; }
	public String? ObjectId { get; set; }
}
public sealed partial record class GitRefResult
{
	public List<GitRef>? Value { get; set; }
}
public sealed partial record class GitRefUpdate
{
	public String? Name { get; set; }
	public String? OldObjectId { get; set; }
	public String? NewObjectId { get; set; }
}
public sealed partial record class GitRefUpdateRequest
{
	public List<GitRefUpdate>? Value { get; set; }
}
public sealed partial record class GitRefUpdateResponse
{
	public List<GitRefUpdateResult>? Value { get; set; }
}
public sealed partial record class GitRefUpdateResult
{
	public String? Name { get; set; }
	public String? OldObjectId { get; set; }
	public String? NewObjectId { get; set; }
	public bool? WasSuccessful { get; set; }
}
public sealed partial record class GitRepository : ILinks
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
public sealed partial record class PipelineRunRequest
{
	public List<String>? StagesToSkip { get; set; }
	public RunResources? Resources { get; set; }
}
public sealed partial record class PipelinesResult
{
	public int? Count { get; set; }
	public List<Pipeline>? Value { get; set; }
}
public sealed partial record class Pipeline : ILinks
{
	public ReferenceLinks? Links { get; set; }
	public int? Id { get; set; }
	public String? Folder { get; set; }
	public String? Name { get; set; }
	public int? Revision { get; set; }
	public String? Url { get; set; }
}
public sealed partial record class Project
{
	public String? Id { get; set; }
	public String? Name { get; set; }
	public String? Url { get; set; }
	public String? State { get; set; }
	public int? Revision { get; set; }
	public String? Visibility { get; set; }
	public String? LastUpdateTime { get; set; }
}
public sealed partial record class RunsResult
{
	public int? Count { get; set; }
	public List<Run>? Value { get; set; }
}
public sealed partial record class Run : ILinks
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
public sealed partial record class RunResources
{
	public PipelineRunResources? Pipelines { get; set; }
	public RepositoryRunResources? Repositories { get; set; }
}
public sealed partial record class PipelineRunResources
{
	public Dictionary<String, PipelineRunResource>? All { get; set; }
}
public sealed partial record class PipelineRunResource
{
	public Pipeline? Pipeline { get; set; }
	public String? Version { get; set; }
}
public sealed partial record class RepositoryRunResources
{
	public Dictionary<String, RepositoryRunResource>? All { get; set; }
}
public sealed partial record class RepositoryRunResource
{
	public String? RefName { get; set; }
	public Respository? Repository { get; set; }
	public String? Version { get; set; }
}
public sealed partial record class Respository
{
	public String? Id { get; set; }
	public String? Type { get; set; }
}
public sealed partial record class PullRequestThreadsResult
{
	public List<PullRequestThread>? Value { get; set; }
}
public sealed partial record class PullRequestThread
{
	public int? Id { get; set; }
	public bool? IsDeleted { get; set; }
	public List<PullRequestThreadComment>? Comments { get; set; }
	public String? Status { get; set; }
}
public sealed partial record class PullRequestThreadComment
{
	public int? Id { get; set; }
	public String? Content { get; set; }
	public String? CommentType { get; set; }
	public int? ParentCommentId { get; set; }
}
public sealed partial record class ReleasesResult
{
	public int? Count { get; set; }
	public List<Release>? Value { get; set; }
}
public sealed partial record class Release : ILinks
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
public sealed partial record class ReleaseArtifact
{
	public String? alias { get; set; }
	public ReleaseArtifactDefinitionReference? definitionReference { get; set; }
}
public sealed partial record class ReleaseArtifactDefinitionReference
{
	public IdReference? sourceVersion { get; set; }
}
public sealed partial record class ReleaseDefinitionsResult
{
	public int? Count { get; set; }
	public List<ReleaseDefinition>? Value { get; set; }
}
public sealed partial record class ReleaseDefinition : ILinks
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
public sealed partial record class ReleaseEnvironment
{
	public int? id { get; set; }
	public String? name { get; set; }
	public String? status { get; set; }
	public int? definitionEnvironmentId { get; set; }
}
public sealed partial record class ReleasePropertiesCollection
{
}
public sealed partial record class IdReference
{
	public String? id { get; set; }
	public String? name { get; set; }
}
public sealed partial record class IdentityRef : ILinks
{
	public ReferenceLinks? Links { get; set; }
	public String? displayName { get; set; }
	public String? url { get; set; }
	public String? id { get; set; }
	public String? uniqueName { get; set; }
	public String? imageUrl { get; set; }
	public String? descriptor { get; set; }
}
public sealed partial record class ProjectReference
{
	public String? id { get; set; }
	public String? name { get; set; }
}
public sealed partial record class ReferenceLinks
{
	public ReferenceLink? Self { get; set; }
	public ReferenceLink? Web { get; set; }
	public Dictionary<String, ReferenceLink>? All { get; set; }
}
public sealed partial record class ReferenceLink
{
	public String? Href { get; set; }
}
public sealed partial record class Variables
{
	public Dictionary<String, VariableValue>? All { get; set; }
}
public sealed partial record class VariableValue
{
	public String? Value { get; set; }
}
public sealed partial record class VariableGroups
{
}
public partial interface ILinks
{
	ReferenceLinks? Links { get; set; }
}
public sealed partial record class TemplateParameters
{
}
