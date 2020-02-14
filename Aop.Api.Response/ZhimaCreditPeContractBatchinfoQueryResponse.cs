using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCreditPeContractBatchinfoQueryResponse : AopResponse
	{
		[XmlElement("batch_record")]
		public long BatchRecord
		{
			get;
			set;
		}

		[XmlElement("data_content")]
		public string DataContent
		{
			get;
			set;
		}

		[XmlElement("md_5_sign")]
		public string Md5Sign
		{
			get;
			set;
		}

		[XmlElement("next_batch_index")]
		public long NextBatchIndex
		{
			get;
			set;
		}

		[XmlElement("total_record")]
		public long TotalRecord
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
