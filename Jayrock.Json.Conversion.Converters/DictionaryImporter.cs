using System.Collections;

namespace Jayrock.Json.Conversion.Converters
{
	public class DictionaryImporter : ImportAwareImporter
	{
		public DictionaryImporter()
			: base(typeof(IDictionary))
		{
		}

		protected override IJsonImportable CreateObject()
		{
			return new JsonObject();
		}
	}
}
