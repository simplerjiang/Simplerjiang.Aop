using Jayrock.Collections;
using System;

namespace Jayrock.Json.Conversion
{
	[Serializable]
	internal sealed class ImporterCollection : KeyedCollection
	{
		public IImporter this[Type type] => (IImporter)GetByKey(type);

		public void Put(IImporter importer)
		{
			if (importer == null)
			{
				throw new ArgumentNullException("importer");
			}
			Remove(importer.OutputType);
			Add(importer);
		}

		public void Add(IImporter importer)
		{
			if (importer == null)
			{
				throw new ArgumentNullException("importer");
			}
			Add((object)importer);
		}

		protected override object KeyFromValue(object value)
		{
			return ((IImporter)value).OutputType;
		}
	}
}
