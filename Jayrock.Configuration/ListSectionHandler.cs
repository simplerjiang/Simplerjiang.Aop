using System;
using System.Collections;
using System.Configuration;
using System.Xml;

namespace Jayrock.Configuration
{
	public abstract class ListSectionHandler : IConfigurationSectionHandler
	{
		private readonly string _elementName;

		protected string ElementName => _elementName;

		protected ListSectionHandler(string elementName)
		{
			if (elementName == null)
			{
				throw new ArgumentNullException("elementName");
			}
			if (elementName.Length == 0)
			{
				throw new ArgumentException("elementName");
			}
			_elementName = elementName;
		}

		public virtual object Create(object parent, object configContext, XmlNode section)
		{
			if (section == null)
			{
				throw new ArgumentNullException("section");
			}
			IList list = CreateList(parent);
			string elementName = ElementName;
			foreach (XmlNode childNode in section.ChildNodes)
			{
				if (childNode.NodeType != XmlNodeType.Comment && childNode.NodeType != XmlNodeType.Whitespace)
				{
					if (childNode.NodeType != XmlNodeType.Element)
					{
						throw new ConfigurationErrorsException($"Unexpected type of node ({childNode.NodeType.ToString()}) in configuration.", childNode);
					}
					if (childNode.Name != elementName)
					{
						throw new ConfigurationErrorsException($"Element <{childNode.Name}> is not valid here in configuration. Use <{elementName}> elements only.", childNode);
					}
					list.Add(GetItem((XmlElement)childNode));
				}
			}
			return list;
		}

		protected virtual IList CreateList(object parent)
		{
			return (parent != null) ? new ArrayList((ICollection)parent) : new ArrayList(4);
		}

		protected abstract object GetItem(XmlElement element);
	}
}
