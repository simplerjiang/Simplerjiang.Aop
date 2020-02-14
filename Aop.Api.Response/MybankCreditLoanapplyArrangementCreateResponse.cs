using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditLoanapplyArrangementCreateResponse : AopResponse
	{
		[XmlElement("ar_no")]
		public string ArNo
		{
			get;
			set;
		}
	}
}
