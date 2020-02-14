using System;

namespace Jayrock.Json.Conversion.Converters
{
	public class ImportAwareImporter : ImporterBase
	{
		public ImportAwareImporter(Type type)
			: base(type)
		{
		}

		protected override object ImportFromBoolean(ImportContext context, JsonReader reader)
		{
			return ReflectImport(context, reader);
		}

		protected override object ImportFromNumber(ImportContext context, JsonReader reader)
		{
			return ReflectImport(context, reader);
		}

		protected override object ImportFromString(ImportContext context, JsonReader reader)
		{
			return ReflectImport(context, reader);
		}

		protected override object ImportFromArray(ImportContext context, JsonReader reader)
		{
			return ReflectImport(context, reader);
		}

		protected override object ImportFromObject(ImportContext context, JsonReader reader)
		{
			return ReflectImport(context, reader);
		}

		private object ReflectImport(ImportContext context, JsonReader reader)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			IJsonImportable jsonImportable = CreateObject();
			jsonImportable.Import(context, reader);
			return jsonImportable;
		}

		protected virtual IJsonImportable CreateObject()
		{
			return (IJsonImportable)Activator.CreateInstance(base.OutputType);
		}
	}
}
