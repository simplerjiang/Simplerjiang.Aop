using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserNewbenefitCreateModel : AopObject
	{
		[XmlElement("area_code")]
		public string AreaCode
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

		[XmlElement("differentiation")]
		public string Differentiation
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

		[XmlElement("start_dt")]
		public long StartDt
		{
			get;
			set;
		}
	}
}
