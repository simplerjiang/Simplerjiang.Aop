using System;
using System.IO;
using System.Text;

namespace Jayrock.Json.Conversion
{
	public sealed class JsonConvert
	{
		public static void Export(object value, JsonWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			ExportContext exportContext = new ExportContext();
			exportContext.Export(value, writer);
		}

		public static void Export(object value, TextWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			Export(value, new JsonTextWriter(writer));
		}

		public static void Export(object value, StringBuilder sb)
		{
			if (sb == null)
			{
				throw new ArgumentNullException("sb");
			}
			Export(value, new StringWriter(sb));
		}

		public static string ExportToString(object value)
		{
			StringBuilder stringBuilder = new StringBuilder();
			Export(value, stringBuilder);
			return stringBuilder.ToString();
		}

		public static object Import(string text)
		{
			return Import(new StringReader(text));
		}

		public static object Import(TextReader reader)
		{
			return Import(new JsonTextReader(reader));
		}

		public static object Import(JsonReader reader)
		{
			return Import(AnyType.Value, reader);
		}

		public static object Import(Type type, string text)
		{
			return Import(type, new StringReader(text));
		}

		public static object Import(Type type, TextReader reader)
		{
			return Import(type, new JsonTextReader(reader));
		}

		public static object Import(Type type, JsonReader reader)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			ImportContext importContext = new ImportContext();
			return importContext.Import(type, reader);
		}

		private JsonConvert()
		{
			throw new NotSupportedException();
		}
	}
}
