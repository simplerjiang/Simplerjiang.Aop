using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class OpenPromoPrize : AopObject
	{
		[XmlElement("prize_base_rule_amount")]
		public string PrizeBaseRuleAmount
		{
			get;
			set;
		}

		[XmlArray("prize_custom_menu")]
		[XmlArrayItem("prize_custom_menu")]
		public List<PrizeCustomMenu> PrizeCustomMenu
		{
			get;
			set;
		}

		[XmlElement("prize_desc")]
		public string PrizeDesc
		{
			get;
			set;
		}

		[XmlElement("prize_detail_img")]
		public string PrizeDetailImg
		{
			get;
			set;
		}

		[XmlArray("prize_dimension_time")]
		[XmlArrayItem("open_promo_prize_dimension")]
		public List<OpenPromoPrizeDimension> PrizeDimensionTime
		{
			get;
			set;
		}

		[XmlElement("prize_end_time")]
		public string PrizeEndTime
		{
			get;
			set;
		}

		[XmlElement("prize_logo")]
		public string PrizeLogo
		{
			get;
			set;
		}

		[XmlElement("prize_name")]
		public string PrizeName
		{
			get;
			set;
		}

		[XmlElement("prize_relative_time")]
		public OpenPromoPrizeRelativeTime PrizeRelativeTime
		{
			get;
			set;
		}

		[XmlElement("prize_start_time")]
		public string PrizeStartTime
		{
			get;
			set;
		}

		[XmlElement("prize_subtitle")]
		public string PrizeSubtitle
		{
			get;
			set;
		}

		[XmlArray("prize_suitable_shops")]
		[XmlArrayItem("string")]
		public List<string> PrizeSuitableShops
		{
			get;
			set;
		}

		[XmlElement("prize_template_end_time")]
		public string PrizeTemplateEndTime
		{
			get;
			set;
		}

		[XmlElement("prize_template_start_time")]
		public string PrizeTemplateStartTime
		{
			get;
			set;
		}

		[XmlArray("prize_terms")]
		[XmlArrayItem("string")]
		public List<string> PrizeTerms
		{
			get;
			set;
		}

		[XmlElement("prize_type")]
		public string PrizeType
		{
			get;
			set;
		}

		[XmlElement("prize_worth_amount")]
		public string PrizeWorthAmount
		{
			get;
			set;
		}
	}
}
