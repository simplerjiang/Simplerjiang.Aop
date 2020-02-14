using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserAgreementQueryResponse : AopResponse
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

		[XmlElement("device_id")]
		public string DeviceId
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

		[XmlElement("invalid_time")]
		public string InvalidTime
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

		[XmlElement("pricipal_type")]
		public string PricipalType
		{
			get;
			set;
		}

		[XmlElement("principal_id")]
		public string PrincipalId
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

		[XmlElement("sign_time")]
		public string SignTime
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
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

		[XmlElement("valid_time")]
		public string ValidTime
		{
			get;
			set;
		}

		[XmlElement("zm_open_id")]
		public string ZmOpenId
		{
			get;
			set;
		}
	}
}
