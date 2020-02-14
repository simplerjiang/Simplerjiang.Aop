#define DEBUG
using Jayrock.Json.Conversion.Converters;
using System;
using System.Collections;
using System.Configuration;
using System.Diagnostics;

namespace Jayrock.Json.Conversion
{
	[Serializable]
	public class ImportContext
	{
		private ImporterCollection _importers;

		private IDictionary _items;

		private static ImporterCollection _stockImporters;

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

		private ImporterCollection Importers
		{
			get
			{
				if (_importers == null)
				{
					_importers = new ImporterCollection();
				}
				return _importers;
			}
		}

		private static ImporterCollection StockImporters
		{
			get
			{
				if (_stockImporters == null)
				{
					ImporterCollection importerCollection = new ImporterCollection();
					importerCollection.Add(new ByteImporter());
					importerCollection.Add(new Int16Importer());
					importerCollection.Add(new Int32Importer());
					importerCollection.Add(new Int64Importer());
					importerCollection.Add(new SingleImporter());
					importerCollection.Add(new DoubleImporter());
					importerCollection.Add(new DecimalImporter());
					importerCollection.Add(new StringImporter());
					importerCollection.Add(new BooleanImporter());
					importerCollection.Add(new DateTimeImporter());
					importerCollection.Add(new GuidImporter());
					importerCollection.Add(new ByteArrayImporter());
					importerCollection.Add(new AnyImporter());
					importerCollection.Add(new DictionaryImporter());
					importerCollection.Add(new ListImporter());
					IList list = (IList)ConfigurationManager.GetSection("jayrock/json.conversion.importers");
					if (list != null && list.Count > 0)
					{
						foreach (Type item in list)
						{
							importerCollection.Add((IImporter)Activator.CreateInstance(item));
						}
					}
					_stockImporters = importerCollection;
				}
				return _stockImporters;
			}
		}

		public virtual object Import(JsonReader reader)
		{
			return Import(AnyType.Value, reader);
		}

		public virtual object Import(Type type, JsonReader reader)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			IImporter importer = FindImporter(type);
			if (importer == null)
			{
				throw new JsonException($"Don't know how to import {type.FullName} from JSON.");
			}
			reader.MoveToContent();
			return importer.Import(this, reader);
		}

		public virtual void Register(IImporter importer)
		{
			if (importer == null)
			{
				throw new ArgumentNullException("importer");
			}
			Importers.Put(importer);
		}

		public virtual IImporter FindImporter(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			IImporter importer = Importers[type];
			if (importer != null)
			{
				return importer;
			}
			importer = StockImporters[type];
			if (importer == null)
			{
				importer = FindCompatibleImporter(type);
			}
			if (importer != null)
			{
				Register(importer);
				return importer;
			}
			return null;
		}

		private static IImporter FindCompatibleImporter(Type type)
		{
			Debug.Assert(type != null);
			if (typeof(IJsonImportable).IsAssignableFrom(type))
			{
				return new ImportAwareImporter(type);
			}
			if (type.IsArray && type.GetArrayRank() == 1)
			{
				return new ArrayImporter(type);
			}
			if (type.IsEnum)
			{
				return new EnumImporter(type);
			}
			if ((type.IsPublic || type.IsNestedPublic) && !type.IsPrimitive && type.GetConstructor(Type.EmptyTypes) != null)
			{
				return new ComponentImporter(type);
			}
			return null;
		}
	}
}
