using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFundTransBatchCreateorderResponse : AopResponse
	{
		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("ext_param")]
		public string ExtParam
		{
			get;
			set;
		}

		[XmlElement("transfer_no")]
		public string TransferNo
		{
			get;
			set;
		}
	}
}
