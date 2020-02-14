using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobileStdPublicExpressUserQueryResponse : AopResponse
	{
		[XmlElement("cert_no")]
		public string CertNo
		{
			get;
			set;
		}

		[XmlElement("cert_type")]
		public string CertType
		{
			get;
			set;
		}
	}
}
