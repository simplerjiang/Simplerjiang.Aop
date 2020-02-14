using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserAgreementQueryModel : AopObject
	{
		[XmlElement("agreement_no")]
		public string AgreementNo
		{
			get;
			set;
		}

		[XmlElement("alipay_logon_id")]
		public string AlipayLogonId
		{
			get;
			set;
		}

		[XmlElement("alipay_user_id")]
		public string AlipayUserId
		{
			get;
			set;
		}

		[XmlElement("external_agreement_no")]
		public string ExternalAgreementNo
		{
			get;
			set;
		}

		[XmlElement("personal_product_code")]
		public string PersonalProductCode
		{
			get;
			set;
		}

		[XmlElement("sign_scene")]
		public string SignScene
		{
			get;
			set;
		}

		[XmlElement("third_party_type")]
		public string ThirdPartyType
		{
			get;
			set;
		}
	}
}
