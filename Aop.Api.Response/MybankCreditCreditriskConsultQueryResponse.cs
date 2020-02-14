using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditCreditriskConsultQueryResponse : AopResponse
	{
		[XmlElement("available_amt")]
		public string AvailableAmt
		{
			get;
			set;
		}

		[XmlElement("consult_result_code")]
		public string ConsultResultCode
		{
			get;
			set;
		}

		[XmlElement("consult_result_msg")]
		public string ConsultResultMsg
		{
			get;
			set;
		}
	}
}
