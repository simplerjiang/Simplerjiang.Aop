using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaCreditWatchlistiiGetModel : AopObject
	{
		[XmlElement("product_code")]
		public string ProductCode
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
