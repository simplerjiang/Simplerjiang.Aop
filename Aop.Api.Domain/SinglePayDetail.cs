using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SinglePayDetail : AopObject
	{
		[XmlElement("alipay_order_no")]
		public string AlipayOrderNo
		{
			get;
			set;
		}

		[XmlElement("amount")]
		public string Amount
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

		[XmlElement("modified_time")]
		public string ModifiedTime
		{
			get;
			set;
		}

		[XmlElement("pay_url")]
		public string PayUrl
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

		[XmlElement("transfer_order_no")]
		public string TransferOrderNo
		{
			get;
			set;
		}

		[XmlElement("transfer_out_order_no")]
		public string TransferOutOrderNo
		{
			get;
			set;
		}
	}
}
