using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaMerchantOrderRentCompleteModel : AopObject
	{
		[XmlElement("extend_info")]
		public string ExtendInfo
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

		[XmlElement("pay_amount")]
		public string PayAmount
		{
			get;
			set;
		}

		[XmlElement("pay_amount_type")]
		public string PayAmountType
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

		[XmlElement("restore_shop_name")]
		public string RestoreShopName
		{
			get;
			set;
		}

		[XmlElement("restore_time")]
		public string RestoreTime
		{
			get;
			set;
		}
	}
}
