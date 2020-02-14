using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceAirXfgDsgModifyModel : AopObject
	{
		[XmlElement("age")]
		public string Age
		{
			get;
			set;
		}

		[XmlElement("nam")]
		public string Nam
		{
			get;
			set;
		}

		[XmlElement("sex")]
		public string Sex
		{
			get;
			set;
		}

		[XmlElement("xbw")]
		public string Xbw
		{
			get;
			set;
		}
	}
}
