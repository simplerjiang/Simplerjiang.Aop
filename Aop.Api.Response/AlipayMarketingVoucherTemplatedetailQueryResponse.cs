using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingVoucherTemplatedetailQueryResponse : AopResponse
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("floor_amount")]
		public string FloorAmount
		{
			get;
			set;
		}

		[XmlElement("publish_amount")]
		public string PublishAmount
		{
			get;
			set;
		}

		[XmlElement("publish_count")]
		public long PublishCount
		{
			get;
			set;
		}

		[XmlElement("publish_end_time")]
		public string PublishEndTime
		{
			get;
			set;
		}

		[XmlElement("publish_start_time")]
		public string PublishStartTime
		{
			get;
			set;
		}

		[XmlElement("recycle_amount")]
		public string RecycleAmount
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("template_id")]
		public string TemplateId
		{
			get;
			set;
		}

		[XmlElement("total_amount")]
		public string TotalAmount
		{
			get;
			set;
		}

		[XmlElement("used_amount")]
		public string UsedAmount
		{
			get;
			set;
		}

		[XmlElement("used_count")]
		public long UsedCount
		{
			get;
			set;
		}

		[XmlElement("voucher_description")]
		public string VoucherDescription
		{
			get;
			set;
		}

		[XmlElement("voucher_name")]
		public string VoucherName
		{
			get;
			set;
		}

		[XmlElement("voucher_quantity")]
		public long VoucherQuantity
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

		[XmlElement("voucher_valid_period")]
		public string VoucherValidPeriod
		{
			get;
			set;
		}
	}
}
