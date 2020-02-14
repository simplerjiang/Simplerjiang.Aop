using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarParkingAgreementQueryResponse : AopResponse
	{
		[XmlElement("agreement_status")]
		public string AgreementStatus
		{
			get;
			set;
		}
	}
}
