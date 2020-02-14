using System;
using System.Collections;
using System.Configuration;
using System.Xml;

namespace Jayrock.Configuration
{
	public class DictionarySectionHandler : IConfigurationSectionHandler
	{
		protected virtual string KeyName => "key";

		protected virtual string ValueName => "value";

		public virtual object Create(object parent, object configContext, XmlNode section)
		{
			if (section == null)
			{
				throw new ArgumentNullException("section");
			}
			IDictionary dictionary = CreateDictionary(parent);
			string keyName = KeyName;
			foreach (XmlNode childNode in section.ChildNodes)
			{
				if (childNode.NodeType != XmlNodeType.Comment && childNode.NodeType != XmlNodeType.Whitespace)
				{
					if (childNode.NodeType != XmlNodeType.Element)
					{
						throw new ConfigurationErrorsException($"Unexpected type of node ({childNode.NodeType.ToString()}) in configuration.", childNode);
					}
					string name = childNode.Name;
					if (name == "clear")
					{
						OnClear(dictionary);
					}
					else
					{
						string text = childNode.Attributes[keyName]?.Value;
						if (text == null || text.Length == 0)
						{
							throw new ConfigurationErrorsException("Missing entry key.", childNode);
						}
						if (name == "add")
						{
							OnAdd(dictionary, text, childNode);
						}
						else
						{
							if (!(name == "remove"))
							{
								throw new ConfigurationErrorsException($"'{name}' is not a valid dictionary node. Use add, remove or clear.", childNode);
							}
							OnRemove(dictionary, text);
						}
					}
				}
			}
			return dictionary;
		}

		protected virtual IDictionary CreateDictionary(object parent)
		{
			return (parent != null) ? new Hashtable((IDictionary)parent, StringComparer.InvariantCultureIgnoreCase) : new Hashtable(StringComparer.InvariantCultureIgnoreCase);
		}

		protected virtual void OnAdd(IDictionary dictionary, string key, XmlNode node)
		{
			if (dictionary == null)
			{
				throw new ArgumentNullException("dictionary");
			}
			if (node == null)
			{
				throw new ArgumentNullException("node");
			}
			dictionary.Add(key, node.Attributes[ValueName]?.Value);
		}

		protected virtual void OnRemove(IDictionary dictionary, string key)
		{
			if (dictionary == null)
			{
				throw new ArgumentNullException("dictionary");
			}
			dictionary.Remove(key);
		}

		protected virtual void OnClear(IDictionary dictionary)
		{
			if (dictionary == null)
			{
				throw new ArgumentNullException("dictionary");
			}
			dictionary.Clear();
		}
	}
}
