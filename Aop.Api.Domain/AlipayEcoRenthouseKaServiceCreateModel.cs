using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoRenthouseKaServiceCreateModel : AopObject
	{
		[XmlElement("address")]
		public string Address
		{
			get;
			set;
		}

		[XmlElement("ka_code")]
		public string KaCode
		{
			get;
			set;
		}

		[XmlElement("type")]
		public long Type
		{
			get;
			set;
		}
	}
}
