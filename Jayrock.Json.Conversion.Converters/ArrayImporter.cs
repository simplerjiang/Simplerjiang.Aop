#define DEBUG
using System;
using System.Collections;
using System.Diagnostics;

namespace Jayrock.Json.Conversion.Converters
{
	public sealed class ArrayImporter : ImporterBase
	{
		public ArrayImporter()
			: this(null)
		{
		}

		public ArrayImporter(Type arrayType)
			: base(AssertArrayType(arrayType))
		{
		}

		private static Type AssertArrayType(Type type)
		{
			if (type == null)
			{
				return typeof(object[]);
			}
			if (!type.IsArray)
			{
				throw new ArgumentException($"{type.FullName} is not an array.", "arrayType");
			}
			if (type.GetArrayRank() != 1)
			{
				throw new ArgumentException($"{type.FullName} is not one-dimension array. Multi-dimensional arrays are not supported.", "arrayType");
			}
			return type;
		}

		protected override object ImportFromArray(ImportContext context, JsonReader reader)
		{
			Debug.Assert(context != null);
			Debug.Assert(reader != null);
			reader.Read();
			ArrayList arrayList = new ArrayList();
			Type elementType = base.OutputType.GetElementType();
			while (reader.TokenClass != JsonTokenClass.EndArray)
			{
				arrayList.Add(context.Import(elementType, reader));
			}
			return ImporterBase.ReadReturning(reader, arrayList.ToArray(elementType));
		}

		protected override object ImportFromBoolean(ImportContext context, JsonReader reader)
		{
			return ImportScalarAsArray(context, reader);
		}

		protected override object ImportFromNumber(ImportContext context, JsonReader reader)
		{
			return ImportScalarAsArray(context, reader);
		}

		protected override object ImportFromString(ImportContext context, JsonReader reader)
		{
			return ImportScalarAsArray(context, reader);
		}

		private object ImportScalarAsArray(ImportContext context, JsonReader reader)
		{
			Debug.Assert(context != null);
			Debug.Assert(reader != null);
			Type elementType = base.OutputType.GetElementType();
			Array array = Array.CreateInstance(elementType, 1);
			array.SetValue(context.Import(elementType, reader), 0);
			return array;
		}
	}
}
