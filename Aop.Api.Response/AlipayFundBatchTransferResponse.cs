using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFundBatchTransferResponse : AopResponse
	{
		[XmlElement("batch_no")]
		public string BatchNo
		{
			get;
			set;
		}

		[XmlElement("batch_trans_id")]
		public string BatchTransId
		{
			get;
			set;
		}
	}
}
