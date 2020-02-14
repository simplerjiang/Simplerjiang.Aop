using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditSupplychainTradePayConfirmResponse : AopResponse
	{
		[XmlElement("ev_seq_no")]
		public string EvSeqNo
		{
			get;
			set;
		}
	}
}
