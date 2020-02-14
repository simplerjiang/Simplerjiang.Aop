using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaMerchantOrderRentModifyModel : AopObject
	{
		[XmlElement("borrow_time")]
		public string BorrowTime
		{
			get;
			set;
		}

		[XmlElement("expiry_time")]
		public string ExpiryTime
		{
			get;
			set;
		}

		[XmlElement("order_no")]
		public string OrderNo
		{
			get;
			set;
		}

		[XmlElement("product_code")]
		public string ProductCode
		{
			get;
			set;
		}
	}
}
