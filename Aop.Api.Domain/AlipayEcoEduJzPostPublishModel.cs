using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoEduJzPostPublishModel : AopObject
	{
		[XmlElement("age_demand")]
		public EduAgeDemand AgeDemand
		{
			get;
			set;
		}

		[XmlElement("commission")]
		public string Commission
		{
			get;
			set;
		}

		[XmlElement("company_contact")]
		public string CompanyContact
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

		[XmlElement("contact_phone")]
		public string ContactPhone
		{
			get;
			set;
		}

		[XmlElement("date_end")]
		public string DateEnd
		{
			get;
			set;
		}

		[XmlElement("date_start")]
		public string DateStart
		{
			get;
			set;
		}

		[XmlElement("deadline")]
		public string Deadline
		{
			get;
			set;
		}

		[XmlElement("gender")]
		public string Gender
		{
			get;
			set;
		}

		[XmlElement("hire_number")]
		public string HireNumber
		{
			get;
			set;
		}

		[XmlElement("is_commission")]
		public string IsCommission
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

		[XmlElement("job_type")]
		public string JobType
		{
			get;
			set;
		}

		[XmlElement("part_time_type")]
		public string PartTimeType
		{
			get;
			set;
		}

		[XmlElement("payment")]
		public string Payment
		{
			get;
			set;
		}

		[XmlElement("payment_remark")]
		public string PaymentRemark
		{
			get;
			set;
		}

		[XmlElement("payment_type")]
		public string PaymentType
		{
			get;
			set;
		}

		[XmlElement("salary")]
		public string Salary
		{
			get;
			set;
		}

		[XmlElement("salary_unit")]
		public string SalaryUnit
		{
			get;
			set;
		}

		[XmlElement("service_post_id")]
		public string ServicePostId
		{
			get;
			set;
		}

		[XmlElement("source_info")]
		public EduSourceInfo SourceInfo
		{
			get;
			set;
		}

		[XmlArray("special_demand")]
		[XmlArrayItem("string")]
		public List<string> SpecialDemand
		{
			get;
			set;
		}

		[XmlElement("title")]
		public string Title
		{
			get;
			set;
		}

		[XmlArray("welfare")]
		[XmlArrayItem("string")]
		public List<string> Welfare
		{
			get;
			set;
		}

		[XmlArray("work_address")]
		[XmlArrayItem("edu_work_address")]
		public List<EduWorkAddress> WorkAddress
		{
			get;
			set;
		}

		[XmlElement("work_time_remark")]
		public string WorkTimeRemark
		{
			get;
			set;
		}

		[XmlElement("working_hours")]
		public string WorkingHours
		{
			get;
			set;
		}
	}
}
