using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaCreditPeContractBatchinfoQueryModel : AopObject
	{
		[XmlElement("activity_name")]
		public string ActivityName
		{
			get;
			set;
		}

		[XmlElement("batch_index")]
		public long BatchIndex
		{
			get;
			set;
		}

		[XmlElement("category")]
		public string Category
		{
			get;
			set;
		}

		[XmlElement("query_date")]
		public string QueryDate
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
