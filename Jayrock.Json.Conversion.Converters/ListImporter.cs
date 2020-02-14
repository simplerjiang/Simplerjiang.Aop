using System.Collections;

namespace Jayrock.Json.Conversion.Converters
{
	public class ListImporter : ImportAwareImporter
	{
		public ListImporter()
			: base(typeof(IList))
		{
		}

		protected override IJsonImportable CreateObject()
		{
			return new JsonArray();
		}
	}
}
