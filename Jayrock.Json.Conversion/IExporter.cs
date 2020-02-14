using System;

namespace Jayrock.Json.Conversion
{
	public interface IExporter
	{
		Type InputType
		{
			get;
		}

		void Export(ExportContext context, object value, JsonWriter writer);
	}
}
