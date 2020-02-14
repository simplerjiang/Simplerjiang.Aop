using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppRechargeNotifySendModel : AopObject
	{
		[XmlElement("face_price")]
		public string FacePrice
		{
			get;
			set;
		}

		[XmlElement("gmt_charge")]
		public string GmtCharge
		{
			get;
			set;
		}

		[XmlElement("mobile")]
		public string Mobile
		{
			get;
			set;
		}

		[XmlElement("notify_type")]
		public string NotifyType
		{
			get;
			set;
		}

		[XmlElement("out_user_id")]
		public string OutUserId
		{
			get;
			set;
		}

		[XmlElement("trade_no")]
		public string TradeNo
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
