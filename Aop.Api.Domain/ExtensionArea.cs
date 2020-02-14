using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ExtensionArea : AopObject
	{
		[XmlElement("goto_url")]
		public string GotoUrl
		{
			get;
			set;
		}

		[XmlElement("height")]
		public long Height
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}

		[XmlElement("url")]
		public string Url
		{
			get;
			set;
		}
	}
}
