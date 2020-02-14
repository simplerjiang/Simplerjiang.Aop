using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDataDataserviceHolographicFactorQueryResponse : AopResponse
	{
		[XmlElement("cert_no")]
		public string CertNo
		{
			get;
			set;
		}

		[XmlElement("mobile")]
		public string Mobile
		{
			get;
			set;
		}

		[XmlElement("muti_loan_factor_map")]
		public string MutiLoanFactorMap
		{
			get;
			set;
		}

		[XmlElement("rsm_factor_map")]
		public string RsmFactorMap
		{
			get;
			set;
		}

		[XmlElement("user_name")]
		public string UserName
		{
			get;
			set;
		}
	}
}
