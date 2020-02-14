using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCardQueryModel : AopObject
	{
		[XmlElement("card_user_info")]
		public CardUserInfo CardUserInfo
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
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
