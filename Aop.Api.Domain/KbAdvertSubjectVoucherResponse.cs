using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertSubjectVoucherResponse : AopObject
	{
		[XmlElement("brand_name")]
		public string BrandName
		{
			get;
			set;
		}

		[XmlArray("city_ids")]
		[XmlArrayItem("string")]
		public List<string> CityIds
		{
			get;
			set;
		}

		[XmlElement("cover")]
		public string Cover
		{
			get;
			set;
		}

		[XmlElement("daily_inventory")]
		public string DailyInventory
		{
			get;
			set;
		}

		[XmlElement("gmt_end")]
		public string GmtEnd
		{
			get;
			set;
		}

		[XmlElement("gmt_start")]
		public string GmtStart
		{
			get;
			set;
		}

		[XmlElement("logo")]
		public string Logo
		{
			get;
			set;
		}

		[XmlArray("manuals")]
		[XmlArrayItem("kbadvert_voucher_manual")]
		public List<KbadvertVoucherManual> Manuals
		{
			get;
			set;
		}

		[XmlElement("merchant_name")]
		public string MerchantName
		{
			get;
			set;
		}

		[XmlElement("partner_id")]
		public string PartnerId
		{
			get;
			set;
		}

		[XmlElement("purchase_mode")]
		public string PurchaseMode
		{
			get;
			set;
		}

		[XmlArray("shop_ids")]
		[XmlArrayItem("string")]
		public List<string> ShopIds
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

		[XmlElement("total_inventory")]
		public string TotalInventory
		{
			get;
			set;
		}

		[XmlElement("voucher_id")]
		public string VoucherId
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

		[XmlElement("voucher_org_value")]
		public string VoucherOrgValue
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

		[XmlElement("voucher_value")]
		public string VoucherValue
		{
			get;
			set;
		}
	}
}
