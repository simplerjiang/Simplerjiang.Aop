using System;

namespace Jayrock.Json.Conversion
{
	public interface IImporter
	{
		Type OutputType
		{
			get;
		}

		object Import(ImportContext context, JsonReader reader);
	}
}
