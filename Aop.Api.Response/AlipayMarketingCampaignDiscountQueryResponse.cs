using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCampaignDiscountQueryResponse : AopResponse
	{
		[XmlElement("camp_code")]
		public string CampCode
		{
			get;
			set;
		}

		[XmlElement("camp_desc")]
		public string CampDesc
		{
			get;
			set;
		}

		[XmlElement("camp_id")]
		public string CampId
		{
			get;
			set;
		}

		[XmlElement("camp_name")]
		public string CampName
		{
			get;
			set;
		}

		[XmlElement("camp_slogan")]
		public string CampSlogan
		{
			get;
			set;
		}

		[XmlElement("camp_status")]
		public string CampStatus
		{
			get;
			set;
		}

		[XmlElement("discount_dst_camp_prize_model")]
		public DiscountDstCampPrizeModel DiscountDstCampPrizeModel
		{
			get;
			set;
		}

		[XmlElement("dst_camp_rule_model")]
		public DstCampRuleModel DstCampRuleModel
		{
			get;
			set;
		}

		[XmlArray("dst_camp_sub_time_model_list")]
		[XmlArrayItem("date_area_model")]
		public List<DateAreaModel> DstCampSubTimeModelList
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

		[XmlElement("prize_type")]
		public string PrizeType
		{
			get;
			set;
		}

		[XmlElement("random_discount_dst_camp_prize_model")]
		public RandomDiscountDstCampPrizeModel RandomDiscountDstCampPrizeModel
		{
			get;
			set;
		}

		[XmlElement("reduce_dst_camp_prize_model")]
		public ReduceDstCampPrizeModel ReduceDstCampPrizeModel
		{
			get;
			set;
		}

		[XmlElement("reduce_to_discount_dst_camp_prize_model")]
		public ReduceToDiscountDstCampPrizeModel ReduceToDiscountDstCampPrizeModel
		{
			get;
			set;
		}

		[XmlElement("reset_zero_dst_camp_prize_model")]
		public ResetZeroDstCampPrizeModel ResetZeroDstCampPrizeModel
		{
			get;
			set;
		}

		[XmlElement("single_dst_camp_prize_model")]
		public SingleDstCampPrizeModel SingleDstCampPrizeModel
		{
			get;
			set;
		}

		[XmlElement("staged_discount_dst_camp_prize_model")]
		public StagedDiscountDstCampPrizeModel StagedDiscountDstCampPrizeModel
		{
			get;
			set;
		}
	}
}
