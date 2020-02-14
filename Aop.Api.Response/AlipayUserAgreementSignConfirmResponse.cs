using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserAgreementSignConfirmResponse : AopResponse
	{
		[XmlElement("agreement_no")]
		public string AgreementNo
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

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
