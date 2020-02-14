using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFundTransTobankTransferResponse : AopResponse
	{
		[XmlElement("arrival_time_end")]
		public string ArrivalTimeEnd
		{
			get;
			set;
		}

		[XmlElement("order_id")]
		public string OrderId
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}
	}
}
