using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCardDeleteModel : AopObject
	{
		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("out_serial_no")]
		public string OutSerialNo
		{
			get;
			set;
		}

		[XmlElement("reason_code")]
		public string ReasonCode
		{
			get;
			set;
		}

		[XmlElement("target_card_no")]
		public string TargetCardNo
		{
			get;
			set;
		}

		[XmlElement("target_card_no_type")]
		public string TargetCardNoType
		{
			get;
			set;
		}
	}
}
