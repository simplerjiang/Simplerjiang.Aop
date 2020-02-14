using System;
using System.Configuration;
using System.Xml;

namespace Jayrock.Configuration
{
	public class TypeListSectionHandler : ListSectionHandler
	{
		private readonly Type _expectedType;

		protected Type ExpectedType => _expectedType;

		public TypeListSectionHandler(string elementName)
			: this(elementName, null)
		{
		}

		public TypeListSectionHandler(string elementName, Type expectedType)
			: base(elementName)
		{
			_expectedType = expectedType;
		}

		protected override object GetItem(XmlElement element)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			string attribute = element.GetAttribute("type");
			if (attribute.Length == 0)
			{
				throw new ConfigurationErrorsException($"Missing type name specification on <{base.ElementName}> element.", element);
			}
			Type type = GetType(attribute);
			ValidateType(type, element);
			return type;
		}

		protected virtual void ValidateType(Type type, XmlElement element)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			if (ExpectedType == null || ExpectedType.IsAssignableFrom(type))
			{
				return;
			}
			throw new ConfigurationErrorsException(string.Format("The type {0} is not valid for the <{2}> configuration element. It must be compatible with the type {1}.", type.FullName, ExpectedType.FullName, element.Name), element);
		}

		protected virtual Type GetType(string typeName)
		{
			if (typeName == null)
			{
				throw new ArgumentNullException("typeName");
			}
			return Compat.GetType(typeName);
		}
	}
}
