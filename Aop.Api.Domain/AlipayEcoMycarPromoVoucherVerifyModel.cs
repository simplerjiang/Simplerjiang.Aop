using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarPromoVoucherVerifyModel : AopObject
	{
		[XmlElement("order_no")]
		public string OrderNo
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

		[XmlElement("sms_code")]
		public string SmsCode
		{
			get;
			set;
		}
	}
}
