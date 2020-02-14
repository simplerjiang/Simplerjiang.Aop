#define DEBUG
using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Jayrock.Json.Conversion.Converters
{
	public sealed class ComponentImporter : ImporterBase
	{
		private readonly PropertyDescriptorCollection _properties;

		public ComponentImporter(Type type)
			: this(type, null)
		{
		}

		public ComponentImporter(Type type, ICustomTypeDescriptor typeDescriptor)
			: base(type)
		{
			if (typeDescriptor == null)
			{
				typeDescriptor = new CustomTypeDescriptor(type);
			}
			_properties = typeDescriptor.GetProperties();
		}

		protected override object ImportFromObject(ImportContext context, JsonReader reader)
		{
			Debug.Assert(context != null);
			Debug.Assert(reader != null);
			reader.Read();
			object obj = Activator.CreateInstance(base.OutputType);
			while (reader.TokenClass != JsonTokenClass.EndObject)
			{
				string name = reader.ReadMember();
				PropertyDescriptor propertyDescriptor = _properties.Find(name, ignoreCase: true);
				if (propertyDescriptor != null && !propertyDescriptor.IsReadOnly)
				{
					propertyDescriptor.SetValue(obj, context.Import(propertyDescriptor.PropertyType, reader));
				}
				else
				{
					reader.Skip();
				}
			}
			return ImporterBase.ReadReturning(reader, obj);
		}
	}
}
