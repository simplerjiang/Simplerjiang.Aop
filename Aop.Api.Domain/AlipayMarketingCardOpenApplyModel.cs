using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCardOpenApplyModel : AopObject
	{
		[XmlElement("card_ext_info")]
		public MerchantCard CardExtInfo
		{
			get;
			set;
		}

		[XmlElement("card_template_id")]
		public string CardTemplateId
		{
			get;
			set;
		}

		[XmlElement("card_user_info")]
		public CardUserInfo CardUserInfo
		{
			get;
			set;
		}

		[XmlElement("member_ext_info")]
		public MerchantMenber MemberExtInfo
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
	}
}
