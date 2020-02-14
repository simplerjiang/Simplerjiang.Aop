using Jayrock.Configuration;

namespace Jayrock.Json.Conversion
{
	internal sealed class ExporterListSectionHandler : TypeListSectionHandler
	{
		public ExporterListSectionHandler()
			: base("exporter", typeof(IExporter))
		{
		}
	}
}
