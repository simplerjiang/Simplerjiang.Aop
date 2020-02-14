#define DEBUG
using System;
using System.Diagnostics;
using System.IO;

namespace Jayrock.Json.Conversion.Converters
{
	public sealed class ByteArrayImporter : ImporterBase
	{
		public ByteArrayImporter()
			: base(typeof(byte[]))
		{
		}

		protected override object ImportFromArray(ImportContext context, JsonReader reader)
		{
			Debug.Assert(context != null);
			Debug.Assert(reader != null);
			reader.Read();
			MemoryStream memoryStream = new MemoryStream();
			Type typeFromHandle = typeof(byte);
			while (reader.TokenClass != JsonTokenClass.EndArray)
			{
				memoryStream.WriteByte((byte)context.Import(typeFromHandle, reader));
			}
			return ImporterBase.ReadReturning(reader, memoryStream.ToArray());
		}

		protected override object ImportFromBoolean(ImportContext context, JsonReader reader)
		{
			return new byte[1]
			{
				(byte)(reader.ReadBoolean() ? 1 : 0)
			};
		}

		protected override object ImportFromNumber(ImportContext context, JsonReader reader)
		{
			return new byte[1]
			{
				reader.ReadNumber().ToByte()
			};
		}

		protected override object ImportFromString(ImportContext context, JsonReader reader)
		{
			try
			{
				return Convert.FromBase64String(reader.ReadString());
			}
			catch (FormatException innerException)
			{
				throw new JsonException("Error converting JSON String containing base64-encode data to " + base.OutputType.FullName + ".", innerException);
			}
		}
	}
}
