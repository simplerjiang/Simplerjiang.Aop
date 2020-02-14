using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayPcreditLoanApplyUserCertifyResponse : AopResponse
	{
		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}
	}
}
