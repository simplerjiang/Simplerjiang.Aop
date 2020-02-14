using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsMerchant : AopObject
	{
		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}

		[XmlElement("service_phone")]
		public string ServicePhone
		{
			get;
			set;
		}

		[XmlElement("short_name")]
		public string ShortName
		{
			get;
			set;
		}
	}
}
