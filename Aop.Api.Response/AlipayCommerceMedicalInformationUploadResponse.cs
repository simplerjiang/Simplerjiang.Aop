using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceMedicalInformationUploadResponse : AopResponse
	{
		[XmlElement("gmt_payment")]
		public string GmtPayment
		{
			get;
			set;
		}

		[XmlElement("response_content")]
		public string ResponseContent
		{
			get;
			set;
		}
	}
}
