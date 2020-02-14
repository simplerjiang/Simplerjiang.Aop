using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditLoanapplyDataQueryResponse : AopResponse
	{
		[XmlElement("data")]
		public string Data
		{
			get;
			set;
		}

		[XmlElement("data_time")]
		public string DataTime
		{
			get;
			set;
		}
	}
}
