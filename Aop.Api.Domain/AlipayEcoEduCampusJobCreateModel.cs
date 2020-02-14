using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoEduCampusJobCreateModel : AopObject
	{
		[XmlElement("area_city_code")]
		public string AreaCityCode
		{
			get;
			set;
		}

		[XmlElement("area_city_name")]
		public string AreaCityName
		{
			get;
			set;
		}

		[XmlElement("area_district_code")]
		public string AreaDistrictCode
		{
			get;
			set;
		}

		[XmlElement("area_district_name")]
		public string AreaDistrictName
		{
			get;
			set;
		}

		[XmlElement("area_job_address")]
		public string AreaJobAddress
		{
			get;
			set;
		}

		[XmlElement("area_province_code")]
		public long AreaProvinceCode
		{
			get;
			set;
		}

		[XmlElement("area_province_name")]
		public string AreaProvinceName
		{
			get;
			set;
		}

		[XmlElement("area_street_name")]
		public string AreaStreetName
		{
			get;
			set;
		}

		[XmlElement("company_lawname")]
		public string CompanyLawname
		{
			get;
			set;
		}

		[XmlElement("company_logo")]
		public string CompanyLogo
		{
			get;
			set;
		}

		[XmlElement("company_name")]
		public string CompanyName
		{
			get;
			set;
		}

		[XmlElement("company_source")]
		public string CompanySource
		{
			get;
			set;
		}

		[XmlElement("content_var")]
		public string ContentVar
		{
			get;
			set;
		}

		[XmlElement("gmt_expired")]
		public string GmtExpired
		{
			get;
			set;
		}

		[XmlElement("gmt_refresh")]
		public string GmtRefresh
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

		[XmlElement("job_desc")]
		public string JobDesc
		{
			get;
			set;
		}

		[XmlElement("job_hire_number")]
		public long JobHireNumber
		{
			get;
			set;
		}

		[XmlElement("job_name")]
		public string JobName
		{
			get;
			set;
		}

		[XmlElement("job_perk")]
		public string JobPerk
		{
			get;
			set;
		}

		[XmlElement("job_resume_lg")]
		public long JobResumeLg
		{
			get;
			set;
		}

		[XmlElement("job_rq_education")]
		public long JobRqEducation
		{
			get;
			set;
		}

		[XmlElement("job_tier_one_code")]
		public string JobTierOneCode
		{
			get;
			set;
		}

		[XmlElement("job_tier_one_name")]
		public string JobTierOneName
		{
			get;
			set;
		}

		[XmlElement("job_tier_three_code")]
		public string JobTierThreeCode
		{
			get;
			set;
		}

		[XmlElement("job_tier_three_name")]
		public string JobTierThreeName
		{
			get;
			set;
		}

		[XmlElement("job_tier_two_code")]
		public string JobTierTwoCode
		{
			get;
			set;
		}

		[XmlElement("job_tier_two_name")]
		public string JobTierTwoName
		{
			get;
			set;
		}

		[XmlElement("job_type")]
		public long JobType
		{
			get;
			set;
		}

		[XmlElement("payment_max")]
		public long PaymentMax
		{
			get;
			set;
		}

		[XmlElement("payment_min")]
		public long PaymentMin
		{
			get;
			set;
		}

		[XmlElement("payment_unit")]
		public long PaymentUnit
		{
			get;
			set;
		}

		[XmlElement("source_code")]
		public string SourceCode
		{
			get;
			set;
		}

		[XmlElement("source_id")]
		public string SourceId
		{
			get;
			set;
		}

		[XmlElement("tra_job_freq")]
		public long TraJobFreq
		{
			get;
			set;
		}

		[XmlElement("tra_job_period")]
		public long TraJobPeriod
		{
			get;
			set;
		}

		[XmlElement("tra_job_promot")]
		public long TraJobPromot
		{
			get;
			set;
		}
	}
}
