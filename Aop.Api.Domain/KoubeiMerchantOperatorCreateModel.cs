using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMerchantOperatorCreateModel : AopObject
	{
		[XmlElement("auth_code")]
		public string AuthCode
		{
			get;
			set;
		}

		[XmlElement("department_id")]
		public string DepartmentId
		{
			get;
			set;
		}

		[XmlElement("discount_limit_unit")]
		public string DiscountLimitUnit
		{
			get;
			set;
		}

		[XmlElement("discount_limit_value")]
		public string DiscountLimitValue
		{
			get;
			set;
		}

		[XmlElement("free_limit_unit")]
		public string FreeLimitUnit
		{
			get;
			set;
		}

		[XmlElement("free_limit_value")]
		public string FreeLimitValue
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

		[XmlElement("job_type")]
		public string JobType
		{
			get;
			set;
		}

		[XmlElement("login_id")]
		public string LoginId
		{
			get;
			set;
		}

		[XmlElement("mobile")]
		public string Mobile
		{
			get;
			set;
		}

		[XmlElement("operator_name")]
		public string OperatorName
		{
			get;
			set;
		}

		[XmlElement("role_id")]
		public string RoleId
		{
			get;
			set;
		}
	}
}
