using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppPdeductSignCancelResponse : AopResponse
	{
		[XmlElement("agreement_id")]
		public string AgreementId
		{
			get;
			set;
		}

		[XmlElement("agreement_status")]
		public string AgreementStatus
		{
			get;
			set;
		}

		[XmlElement("out_agreement_id")]
		public string OutAgreementId
		{
			get;
			set;
		}
	}
}
