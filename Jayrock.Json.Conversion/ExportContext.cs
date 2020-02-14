#define DEBUG
using Jayrock.Json.Conversion.Converters;
using System;
using System.Collections;
using System.Configuration;
using System.Diagnostics;

namespace Jayrock.Json.Conversion
{
	[Serializable]
	public class ExportContext
	{
		private ExporterCollection _exporters;

		private IDictionary _items;

		private static ExporterCollection _stockExporters;

		public IDictionary Items
		{
			get
			{
				if (_items == null)
				{
					_items = new Hashtable();
				}
				return _items;
			}
		}

		private ExporterCollection Exporters
		{
			get
			{
				if (_exporters == null)
				{
					_exporters = new ExporterCollection();
				}
				return _exporters;
			}
		}

		private static ExporterCollection StockExporters
		{
			get
			{
				if (_stockExporters == null)
				{
					ExporterCollection exporterCollection = new ExporterCollection();
					exporterCollection.Add(new ByteExporter());
					exporterCollection.Add(new Int16Exporter());
					exporterCollection.Add(new Int32Exporter());
					exporterCollection.Add(new Int64Exporter());
					exporterCollection.Add(new SingleExporter());
					exporterCollection.Add(new DoubleExporter());
					exporterCollection.Add(new DecimalExporter());
					exporterCollection.Add(new StringExporter());
					exporterCollection.Add(new BooleanExporter());
					exporterCollection.Add(new DateTimeExporter());
					exporterCollection.Add(new ByteArrayExporter());
					exporterCollection.Add(new DataRowViewExporter());
					exporterCollection.Add(new NameValueCollectionExporter());
					exporterCollection.Add(new DataSetExporter());
					exporterCollection.Add(new DataTableExporter());
					exporterCollection.Add(new DataRowExporter());
					IList list = (IList)ConfigurationManager.GetSection("jayrock/json.conversion.exporters");
					if (list != null && list.Count > 0)
					{
						foreach (Type item in list)
						{
							exporterCollection.Add((IExporter)Activator.CreateInstance(item));
						}
					}
					_stockExporters = exporterCollection;
				}
				return _stockExporters;
			}
		}

		public virtual void Export(object value, JsonWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			if (JsonNull.LogicallyEquals(value))
			{
				writer.WriteNull();
				return;
			}
			IExporter exporter = FindExporter(value.GetType());
			if (exporter != null)
			{
				exporter.Export(this, value, writer);
			}
			else
			{
				writer.WriteString(value.ToString());
			}
		}

		public virtual void Register(IExporter exporter)
		{
			if (exporter == null)
			{
				throw new ArgumentNullException("exporter");
			}
			Exporters.Put(exporter);
		}

		public virtual IExporter FindExporter(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			IExporter exporter = Exporters[type];
			if (exporter != null)
			{
				return exporter;
			}
			exporter = StockExporters[type];
			if (exporter == null)
			{
				exporter = FindCompatibleExporter(type);
			}
			if (exporter != null)
			{
				Register(exporter);
				return exporter;
			}
			return null;
		}

		private IExporter FindCompatibleExporter(Type type)
		{
			Debug.Assert(type != null);
			if (typeof(IJsonExportable).IsAssignableFrom(type))
			{
				return new ExportAwareExporter(type);
			}
			if (type.IsClass && type != typeof(object))
			{
				IExporter exporter = FindBaseExporter(type.BaseType, type);
				if (exporter != null)
				{
					return exporter;
				}
			}
			if (typeof(IDictionary).IsAssignableFrom(type))
			{
				return new DictionaryExporter(type);
			}
			if (typeof(IEnumerable).IsAssignableFrom(type))
			{
				return new EnumerableExporter(type);
			}
			if ((type.IsPublic || type.IsNestedPublic) && !type.IsPrimitive && type.GetConstructor(Type.EmptyTypes) != null)
			{
				return new ComponentExporter(type);
			}
			return new StringExporter(type);
		}

		private IExporter FindBaseExporter(Type baseType, Type actualType)
		{
			Debug.Assert(baseType != null);
			Debug.Assert(actualType != null);
			if (baseType == typeof(object))
			{
				return null;
			}
			IExporter exporter = Exporters[baseType];
			if (exporter == null)
			{
				exporter = StockExporters[baseType];
				if (exporter == null)
				{
					return FindBaseExporter(baseType.BaseType, actualType);
				}
			}
			return (IExporter)Activator.CreateInstance(exporter.GetType(), actualType);
		}
	}
}
