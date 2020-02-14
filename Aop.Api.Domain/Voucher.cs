using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class Voucher : AopObject
	{
		[XmlElement("allow_split")]
		public bool AllowSplit
		{
			get;
			set;
		}

		[XmlElement("available_amount")]
		public string AvailableAmount
		{
			get;
			set;
		}

		[XmlElement("brand_name")]
		public string BrandName
		{
			get;
			set;
		}

		[XmlArray("clause_terms")]
		[XmlArrayItem("clause_term")]
		public List<ClauseTerm> ClauseTerms
		{
			get;
			set;
		}

		[XmlElement("delay_info")]
		public DelayInfo DelayInfo
		{
			get;
			set;
		}

		[XmlElement("desc")]
		public string Desc
		{
			get;
			set;
		}

		[XmlArray("desc_detail_list")]
		[XmlArrayItem("voucher_desc_detail")]
		public List<VoucherDescDetail> DescDetailList
		{
			get;
			set;
		}

		[XmlElement("display_config")]
		public DisplayConfig DisplayConfig
		{
			get;
			set;
		}

		[XmlElement("donate_flag")]
		public string DonateFlag
		{
			get;
			set;
		}

		[XmlElement("effect_type")]
		public string EffectType
		{
			get;
			set;
		}

		[XmlElement("end_time")]
		public string EndTime
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("item_info")]
		public ItemInfo ItemInfo
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

		[XmlElement("max_amount")]
		public string MaxAmount
		{
			get;
			set;
		}

		[XmlElement("multi_use_mode")]
		public string MultiUseMode
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}

		[XmlElement("rate")]
		public string Rate
		{
			get;
			set;
		}

		[XmlElement("relative_time")]
		public string RelativeTime
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

		[XmlElement("start_time")]
		public string StartTime
		{
			get;
			set;
		}

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}

		[XmlArray("use_instructions")]
		[XmlArrayItem("string")]
		public List<string> UseInstructions
		{
			get;
			set;
		}

		[XmlElement("use_rule")]
		public UseRule UseRule
		{
			get;
			set;
		}

		[XmlElement("validate_type")]
		public string ValidateType
		{
			get;
			set;
		}

		[XmlElement("verify_mode")]
		public string VerifyMode
		{
			get;
			set;
		}

		[XmlElement("voucher_img")]
		public string VoucherImg
		{
			get;
			set;
		}

		[XmlElement("voucher_note")]
		public string VoucherNote
		{
			get;
			set;
		}

		[XmlElement("worth_value")]
		public string WorthValue
		{
			get;
			set;
		}
	}
}
