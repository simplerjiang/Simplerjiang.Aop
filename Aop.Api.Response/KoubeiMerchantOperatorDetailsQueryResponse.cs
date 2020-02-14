using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMerchantOperatorDetailsQueryResponse : AopResponse
	{
		[XmlElement("department_id")]
		public string DepartmentId
		{
			get;
			set;
		}

		[XmlElement("department_name")]
		public string DepartmentName
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

		[XmlElement("manage_shops")]
		public string ManageShops
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

		[XmlElement("operator_id")]
		public string OperatorId
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

		[XmlElement("qr_code_url")]
		public string QrCodeUrl
		{
			get;
			set;
		}

		[XmlElement("role_code")]
		public string RoleCode
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

		[XmlElement("role_name")]
		public string RoleName
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
