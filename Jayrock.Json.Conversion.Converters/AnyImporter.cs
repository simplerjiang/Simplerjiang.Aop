namespace Jayrock.Json.Conversion.Converters
{
	public sealed class AnyImporter : ImporterBase
	{
		public AnyImporter()
			: base(AnyType.Value)
		{
		}

		protected override object ImportFromBoolean(ImportContext context, JsonReader reader)
		{
			return BooleanObject.Box(reader.ReadBoolean());
		}

		protected override object ImportFromNumber(ImportContext context, JsonReader reader)
		{
			return reader.ReadNumber();
		}

		protected override object ImportFromString(ImportContext context, JsonReader reader)
		{
			return reader.ReadString();
		}

		protected override object ImportFromArray(ImportContext context, JsonReader reader)
		{
			JsonArray jsonArray = new JsonArray();
			((IJsonImportable)jsonArray).Import(context, reader);
			return jsonArray;
		}

		protected override object ImportFromObject(ImportContext context, JsonReader reader)
		{
			JsonObject jsonObject = new JsonObject();
			((IJsonImportable)jsonObject).Import(context, reader);
			return jsonObject;
		}
	}
}
