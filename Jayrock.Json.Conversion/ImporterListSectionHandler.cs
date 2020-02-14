using Jayrock.Configuration;

namespace Jayrock.Json.Conversion
{
	internal sealed class ImporterListSectionHandler : TypeListSectionHandler
	{
		public ImporterListSectionHandler()
			: base("importer", typeof(IImporter))
		{
		}
	}
}
