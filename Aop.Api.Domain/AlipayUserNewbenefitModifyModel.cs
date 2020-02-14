using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserNewbenefitModifyModel : AopObject
	{
		[XmlElement("area_code")]
		public string AreaCode
		{
			get;
			set;
		}

		[XmlElement("benefit_id")]
		public long BenefitId
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

		[XmlElement("benefit_sub_title")]
		public string BenefitSubTitle
		{
			get;
			set;
		}

		[XmlElement("description")]
		public string Description
		{
			get;
			set;
		}

		[XmlElement("eligible_grade_desc")]
		public string EligibleGradeDesc
		{
			get;
			set;
		}

		[XmlElement("end_dt")]
		public long EndDt
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

		[XmlArray("grade_config")]
		[XmlArrayItem("benefit_grade_config")]
		public List<BenefitGradeConfig> GradeConfig
		{
			get;
			set;
		}

		[XmlElement("icon_url")]
		public string IconUrl
		{
			get;
			set;
		}

		[XmlElement("remove_grades")]
		public string RemoveGrades
		{
			get;
			set;
		}

		[XmlElement("start_dt")]
		public long StartDt
		{
			get;
			set;
		}
	}
}
