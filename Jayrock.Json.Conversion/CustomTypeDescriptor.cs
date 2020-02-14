using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace Jayrock.Json.Conversion
{
	public sealed class CustomTypeDescriptor : ICustomTypeDescriptor
	{
		private abstract class TypeMemberDescriptor : PropertyDescriptor
		{
			protected abstract MemberInfo Member
			{
				get;
			}

			public override bool IsReadOnly => false;

			public override Type ComponentType => Member.DeclaringType;

			public abstract override Type PropertyType
			{
				get;
			}

			protected TypeMemberDescriptor(MemberInfo member, string name)
				: base(ChooseName(name, member.Name), null)
			{
			}

			public override bool Equals(object obj)
			{
				return (obj as TypeMemberDescriptor)?.Member.Equals(Member) ?? false;
			}

			public override int GetHashCode()
			{
				return Member.GetHashCode();
			}

			public override void ResetValue(object component)
			{
			}

			public override bool CanResetValue(object component)
			{
				return false;
			}

			public override bool ShouldSerializeValue(object component)
			{
				return true;
			}

			public abstract override object GetValue(object component);

			public abstract override void SetValue(object component, object value);

			private static string ChooseName(string propsedName, string baseName)
			{
				if (Mask.NullString(propsedName).Length > 0)
				{
					return propsedName;
				}
				return ToCamelCase(baseName);
			}

			private static string ToCamelCase(string s)
			{
				if (s == null || s.Length == 0)
				{
					return s;
				}
				return char.ToLower(s[0], CultureInfo.InvariantCulture).ToString() + s.Substring(1);
			}
		}

		private sealed class TypeFieldDescriptor : TypeMemberDescriptor
		{
			private readonly FieldInfo _field;

			protected override MemberInfo Member => _field;

			public override Type PropertyType => _field.FieldType;

			public TypeFieldDescriptor(FieldInfo field, string name)
				: base(field, name)
			{
				_field = field;
			}

			public override object GetValue(object component)
			{
				return _field.GetValue(component);
			}

			public override void SetValue(object component, object value)
			{
				_field.SetValue(component, value);
				OnValueChanged(component, EventArgs.Empty);
			}
		}

		private sealed class TypePropertyDescriptor : TypeMemberDescriptor
		{
			private readonly PropertyInfo _property;

			protected override MemberInfo Member => _property;

			public override Type PropertyType => _property.PropertyType;

			public TypePropertyDescriptor(PropertyInfo property, string name)
				: base(property, name)
			{
				_property = property;
			}

			public override object GetValue(object component)
			{
				return _property.GetValue(component, null);
			}

			public override void SetValue(object component, object value)
			{
				_property.SetValue(component, value, null);
				OnValueChanged(component, EventArgs.Empty);
			}
		}

		private readonly PropertyDescriptorCollection _properties;

		public CustomTypeDescriptor(Type type)
			: this(type, null)
		{
		}

		public CustomTypeDescriptor(Type type, MemberInfo[] members)
			: this(type, members, null)
		{
		}

		public CustomTypeDescriptor(Type type, MemberInfo[] members, string[] names)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (members == null)
			{
				FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public);
				PropertyInfo[] properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
				ArrayList arrayList = new ArrayList(fields.Length + properties.Length);
				arrayList.AddRange(fields);
				arrayList.AddRange(properties);
				for (int i = 0; i < arrayList.Count; i++)
				{
					MemberInfo memberInfo = (MemberInfo)arrayList[i];
					if (memberInfo.IsDefined(typeof(JsonIgnoreAttribute), inherit: true))
					{
						arrayList.RemoveAt(i--);
					}
				}
				members = (MemberInfo[])arrayList.ToArray(typeof(MemberInfo));
			}
			PropertyDescriptorCollection propertyDescriptorCollection = new PropertyDescriptorCollection(null);
			int num = 0;
			MemberInfo[] array = members;
			foreach (MemberInfo memberInfo2 in array)
			{
				FieldInfo fieldInfo = memberInfo2 as FieldInfo;
				string name = (names != null && num < names.Length) ? names[num] : null;
				if (fieldInfo != null)
				{
					if (fieldInfo.DeclaringType != type && fieldInfo.ReflectedType != type)
					{
						throw new ArgumentException("fields");
					}
					if (!fieldInfo.IsInitOnly && !fieldInfo.IsLiteral)
					{
						propertyDescriptorCollection.Add(new TypeFieldDescriptor(fieldInfo, name));
					}
				}
				else
				{
					PropertyInfo propertyInfo = memberInfo2 as PropertyInfo;
					if (propertyInfo == null)
					{
						throw new ArgumentException("members");
					}
					if (propertyInfo.DeclaringType != type && propertyInfo.ReflectedType != type)
					{
						throw new ArgumentException("properties");
					}
					if (propertyInfo.CanRead && propertyInfo.CanWrite)
					{
						propertyDescriptorCollection.Add(new TypePropertyDescriptor(propertyInfo, name));
					}
				}
				num++;
			}
			_properties = propertyDescriptorCollection;
		}

		public PropertyDescriptorCollection GetProperties()
		{
			return _properties;
		}

		public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
		{
			throw new NotImplementedException();
		}

		public AttributeCollection GetAttributes()
		{
			return AttributeCollection.Empty;
		}

		public string GetClassName()
		{
			return null;
		}

		public string GetComponentName()
		{
			return null;
		}

		public TypeConverter GetConverter()
		{
			return new TypeConverter();
		}

		public EventDescriptor GetDefaultEvent()
		{
			return null;
		}

		public PropertyDescriptor GetDefaultProperty()
		{
			return null;
		}

		public object GetEditor(Type editorBaseType)
		{
			return null;
		}

		public EventDescriptorCollection GetEvents()
		{
			return EventDescriptorCollection.Empty;
		}

		public EventDescriptorCollection GetEvents(Attribute[] attributes)
		{
			return EventDescriptorCollection.Empty;
		}

		public object GetPropertyOwner(PropertyDescriptor pd)
		{
			return null;
		}
	}
}
