using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayItemVoucherTemplete : AopObject
	{
		[XmlElement("delay_minute")]
		public long DelayMinute
		{
			get;
			set;
		}

		[XmlArray("desc_details")]
		[XmlArrayItem("alipay_item_description")]
		public List<AlipayItemDescription> DescDetails
		{
			get;
			set;
		}

		[XmlElement("discount_rate")]
		public long DiscountRate
		{
			get;
			set;
		}

		[XmlElement("external_goods_list")]
		public AlipayItemGoodsList ExternalGoodsList
		{
			get;
			set;
		}

		[XmlArray("limit_period_info_list")]
		[XmlArrayItem("alipay_item_limit_period_info")]
		public List<AlipayItemLimitPeriodInfo> LimitPeriodInfoList
		{
			get;
			set;
		}

		[XmlElement("original_amount")]
		public long OriginalAmount
		{
			get;
			set;
		}

		[XmlElement("original_rate")]
		public long OriginalRate
		{
			get;
			set;
		}

		[XmlElement("reduce_to_amount")]
		public long ReduceToAmount
		{
			get;
			set;
		}

		[XmlElement("rounding_rule")]
		public string RoundingRule
		{
			get;
			set;
		}

		[XmlElement("threshold_amount")]
		public long ThresholdAmount
		{
			get;
			set;
		}

		[XmlElement("threshold_quantity")]
		public long ThresholdQuantity
		{
			get;
			set;
		}

		[XmlElement("valid_period")]
		public long ValidPeriod
		{
			get;
			set;
		}

		[XmlElement("value_amount")]
		public long ValueAmount
		{
			get;
			set;
		}

		[XmlElement("voucher_desc")]
		public string VoucherDesc
		{
			get;
			set;
		}

		[XmlElement("voucher_type")]
		public string VoucherType
		{
			get;
			set;
		}
	}
}
