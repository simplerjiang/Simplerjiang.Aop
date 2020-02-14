using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMsaasMediarecogAftscvpayTransactionInitializeResponse : AopResponse
	{
		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}

		[XmlElement("transaction_id")]
		public string TransactionId
		{
			get;
			set;
		}
	}
}
