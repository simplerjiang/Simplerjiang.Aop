using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditSupplychainPrepaymentCancelResponse : AopResponse
	{
		[XmlElement("ev_seq_no")]
		public string EvSeqNo
		{
			get;
			set;
		}
	}
}
