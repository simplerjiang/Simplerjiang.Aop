using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayDataItemVoucherTemplete : AopObject
	{
		[XmlElement("delay_minute")]
		public long DelayMinute
		{
			get;
			set;
		}

		[XmlArray("desc_details")]
		[XmlArrayItem("alipay_data_item_description")]
		public List<AlipayDataItemDescription> DescDetails
		{
			get;
			set;
		}

		[XmlElement("discount_rate")]
		public string DiscountRate
		{
			get;
			set;
		}

		[XmlElement("external_goods_list")]
		public AlipayDataItemGoodsList ExternalGoodsList
		{
			get;
			set;
		}

		[XmlElement("limit_period_info_list")]
		public AlipayDataItemLimitPeriodInfo LimitPeriodInfoList
		{
			get;
			set;
		}

		[XmlElement("original_amount")]
		public string OriginalAmount
		{
			get;
			set;
		}

		[XmlElement("original_rate")]
		public string OriginalRate
		{
			get;
			set;
		}

		[XmlElement("reduce_to_amount")]
		public string ReduceToAmount
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
		public string ThresholdAmount
		{
			get;
			set;
		}

		[XmlElement("threshold_quantity")]
		public string ThresholdQuantity
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
		public string ValueAmount
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
