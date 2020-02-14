using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CommodityBaseInfo : AopObject
	{
		[XmlElement("logo")]
		public string Logo
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
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

		[XmlElement("service_url")]
		public string ServiceUrl
		{
			get;
			set;
		}
	}
}
