using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditSupplychainPrepaymentApplyResponse : AopResponse
	{
		[XmlElement("prepayment_apply_no")]
		public string PrepaymentApplyNo
		{
			get;
			set;
		}
	}
}
