using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayPointOrderGetResponse : AopResponse
	{
		[XmlElement("alipay_order_no")]
		public string AlipayOrderNo
		{
			get;
			set;
		}

		[XmlElement("create_time")]
		public string CreateTime
		{
			get;
			set;
		}

		[XmlElement("dispatch_user_id")]
		public string DispatchUserId
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlElement("merchant_order_no")]
		public string MerchantOrderNo
		{
			get;
			set;
		}

		[XmlElement("order_status")]
		public string OrderStatus
		{
			get;
			set;
		}

		[XmlElement("point_count")]
		public long PointCount
		{
			get;
			set;
		}

		[XmlElement("receive_user_id")]
		public string ReceiveUserId
		{
			get;
			set;
		}
	}
}
