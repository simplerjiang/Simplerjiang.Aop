using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditLoanapplyInsturlQueryResponse : AopResponse
	{
		[XmlElement("target_url")]
		public string TargetUrl
		{
			get;
			set;
		}
	}
}
