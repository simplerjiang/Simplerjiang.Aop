using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserAgreementSignModel : AopObject
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

		[XmlElement("asset_params")]
		public AssetParams AssetParams
		{
			get;
			set;
		}

		[XmlElement("binded_mobile")]
		public string BindedMobile
		{
			get;
			set;
		}

		[XmlElement("confirm_type")]
		public string ConfirmType
		{
			get;
			set;
		}

		[XmlElement("device_params")]
		public DeviceParams DeviceParams
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

		[XmlElement("prod_params")]
		public ProdParams ProdParams
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

		[XmlElement("sub_merchant")]
		public string SubMerchant
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

		[XmlElement("verify_params")]
		public VerifyParams VerifyParams
		{
			get;
			set;
		}

		[XmlElement("zm_auth_params")]
		public ZmAuthParams ZmAuthParams
		{
			get;
			set;
		}
	}
}
