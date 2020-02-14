#define DEBUG
using System;
using System.Diagnostics;

namespace Jayrock.Json.Conversion.Converters
{
	public abstract class ImporterBase : IImporter
	{
		private readonly Type _outputType;

		public Type OutputType => _outputType;

		protected ImporterBase(Type outputType)
		{
			if (outputType == null)
			{
				throw new ArgumentNullException("outputType");
			}
			_outputType = outputType;
		}

		public virtual object Import(ImportContext context, JsonReader reader)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (!reader.MoveToContent())
			{
				throw new JsonException("Unexpected EOF.");
			}
			if (reader.TokenClass == JsonTokenClass.Null)
			{
				return ImportNull(context, reader);
			}
			if (reader.TokenClass == JsonTokenClass.String)
			{
				return ImportFromString(context, reader);
			}
			if (reader.TokenClass == JsonTokenClass.Number)
			{
				return ImportFromNumber(context, reader);
			}
			if (reader.TokenClass == JsonTokenClass.Boolean)
			{
				return ImportFromBoolean(context, reader);
			}
			if (reader.TokenClass == JsonTokenClass.Array)
			{
				return ImportFromArray(context, reader);
			}
			if (reader.TokenClass == JsonTokenClass.Object)
			{
				return ImportFromObject(context, reader);
			}
			throw new JsonException($"{reader.TokenClass} not expected.");
		}

		protected virtual object ImportNull(ImportContext context, JsonReader reader)
		{
			reader.Read();
			return null;
		}

		protected virtual object ImportFromBoolean(ImportContext context, JsonReader reader)
		{
			return ThrowNotSupported(JsonTokenClass.Boolean);
		}

		protected virtual object ImportFromNumber(ImportContext context, JsonReader reader)
		{
			return ThrowNotSupported(JsonTokenClass.Number);
		}

		protected virtual object ImportFromString(ImportContext context, JsonReader reader)
		{
			return ThrowNotSupported(JsonTokenClass.String);
		}

		protected virtual object ImportFromArray(ImportContext context, JsonReader reader)
		{
			return ThrowNotSupported(JsonTokenClass.Array);
		}

		protected virtual object ImportFromObject(ImportContext context, JsonReader reader)
		{
			return ThrowNotSupported(JsonTokenClass.Object);
		}

		internal static object ReadReturning(JsonReader reader, object result)
		{
			Debug.Assert(reader != null);
			reader.Read();
			return result;
		}

		protected virtual JsonException GetImportException(string jsonValueType)
		{
			return new JsonException($"Cannot import {OutputType} from a JSON {jsonValueType} value.");
		}

		private object ThrowNotSupported(JsonTokenClass clazz)
		{
			Debug.Assert(clazz != null);
			throw GetImportException(clazz.Name);
		}
	}
}
