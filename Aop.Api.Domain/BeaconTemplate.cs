using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class BeaconTemplate : AopObject
	{
		[XmlElement("context")]
		public string Context
		{
			get;
			set;
		}

		[XmlElement("templateid")]
		public string Templateid
		{
			get;
			set;
		}
	}
}
