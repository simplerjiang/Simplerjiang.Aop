using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditSupplychainTradeCancelResponse : AopResponse
	{
		[XmlElement("ev_seq_no")]
		public string EvSeqNo
		{
			get;
			set;
		}
	}
}
