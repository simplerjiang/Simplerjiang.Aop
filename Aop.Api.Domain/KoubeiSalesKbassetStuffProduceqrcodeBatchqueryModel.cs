using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiSalesKbassetStuffProduceqrcodeBatchqueryModel : AopObject
	{
		[XmlElement("batch_id")]
		public string BatchId
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public string PageSize
		{
			get;
			set;
		}

		[XmlElement("produce_order_id")]
		public string ProduceOrderId
		{
			get;
			set;
		}
	}
}
