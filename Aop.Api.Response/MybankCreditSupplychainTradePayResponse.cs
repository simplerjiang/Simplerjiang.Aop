using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditSupplychainTradePayResponse : AopResponse
	{
		[XmlElement("ev_seq_no")]
		public string EvSeqNo
		{
			get;
			set;
		}
	}
}
