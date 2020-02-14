using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserAgreementSignResponse : AopResponse
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

		[XmlElement("apply_token")]
		public string ApplyToken
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

		[XmlElement("forex_eligible")]
		public string ForexEligible
		{
			get;
			set;
		}
	}
}
