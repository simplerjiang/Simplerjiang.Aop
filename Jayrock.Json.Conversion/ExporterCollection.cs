using Jayrock.Collections;
using System;

namespace Jayrock.Json.Conversion
{
	[Serializable]
	internal sealed class ExporterCollection : KeyedCollection
	{
		public IExporter this[Type type] => (IExporter)GetByKey(type);

		public void Put(IExporter exporter)
		{
			if (exporter == null)
			{
				throw new ArgumentNullException("exporter");
			}
			Remove(exporter.InputType);
			Add(exporter);
		}

		public void Add(IExporter exporter)
		{
			if (exporter == null)
			{
				throw new ArgumentNullException("exporter");
			}
			Add((object)exporter);
		}

		protected override object KeyFromValue(object value)
		{
			return ((IExporter)value).InputType;
		}
	}
}
