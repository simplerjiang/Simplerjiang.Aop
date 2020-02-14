using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AgreementSignParams : AopObject
	{
		[XmlElement("buckle_app_id")]
		public string BuckleAppId
		{
			get;
			set;
		}

		[XmlElement("buckle_merchant_id")]
		public string BuckleMerchantId
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

		[XmlElement("external_logon_id")]
		public string ExternalLogonId
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

		[XmlElement("promo_params")]
		public string PromoParams
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

		[XmlElement("sign_validity_period")]
		public string SignValidityPeriod
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
