using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InteligentVoucher : AopObject
	{
		[XmlElement("brand_name")]
		public string BrandName
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

		[XmlArray("inteligent_clause_terms")]
		[XmlArrayItem("inteligent_clause_term")]
		public List<InteligentClauseTerm> InteligentClauseTerms
		{
			get;
			set;
		}

		[XmlElement("inteligent_delay_info")]
		public InteligentDelayInfo InteligentDelayInfo
		{
			get;
			set;
		}

		[XmlArray("inteligent_desc_detail_list")]
		[XmlArrayItem("inteligent_voucher_desc_detail")]
		public List<InteligentVoucherDescDetail> InteligentDescDetailList
		{
			get;
			set;
		}

		[XmlElement("inteligent_display_config")]
		public InteligentDisplayConfig InteligentDisplayConfig
		{
			get;
			set;
		}

		[XmlElement("inteligent_item_info")]
		public InteligentItemInfo InteligentItemInfo
		{
			get;
			set;
		}

		[XmlElement("inteligent_use_rule")]
		public InteligentUseRule InteligentUseRule
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
