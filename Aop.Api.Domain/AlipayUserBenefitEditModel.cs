using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserBenefitEditModel : AopObject
	{
		[XmlElement("benefit_area_code")]
		public string BenefitAreaCode
		{
			get;
			set;
		}

		[XmlElement("benefit_icon_url")]
		public string BenefitIconUrl
		{
			get;
			set;
		}

		[XmlElement("benefit_id")]
		public string BenefitId
		{
			get;
			set;
		}

		[XmlElement("benefit_name")]
		public string BenefitName
		{
			get;
			set;
		}

		[XmlElement("benefit_name_as_area_subtitle")]
		public string BenefitNameAsAreaSubtitle
		{
			get;
			set;
		}

		[XmlElement("benefit_page_url")]
		public string BenefitPageUrl
		{
			get;
			set;
		}

		[XmlElement("benefit_point")]
		public long BenefitPoint
		{
			get;
			set;
		}

		[XmlElement("benefit_rec_biz_id")]
		public string BenefitRecBizId
		{
			get;
			set;
		}

		[XmlElement("benefit_rec_type")]
		public string BenefitRecType
		{
			get;
			set;
		}

		[XmlElement("benefit_subtitle")]
		public string BenefitSubtitle
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

		[XmlElement("eligible_grade")]
		public string EligibleGrade
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

		[XmlElement("exchange_rule_ids")]
		public string ExchangeRuleIds
		{
			get;
			set;
		}

		[XmlElement("grade_discount")]
		public string GradeDiscount
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
	}
}
