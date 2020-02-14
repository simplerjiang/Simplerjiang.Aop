using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserAgreementBatchQueryModel : AopObject
	{
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

		[XmlElement("personal_product_code")]
		public string PersonalProductCode
		{
			get;
			set;
		}

		[XmlElement("product_code")]
		public string ProductCode
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
