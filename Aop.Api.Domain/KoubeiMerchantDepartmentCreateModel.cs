using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMerchantDepartmentCreateModel : AopObject
	{
		[XmlElement("auth_code")]
		public string AuthCode
		{
			get;
			set;
		}

		[XmlElement("dept_name")]
		public string DeptName
		{
			get;
			set;
		}

		[XmlElement("label_code")]
		public string LabelCode
		{
			get;
			set;
		}

		[XmlElement("parent_dept_id")]
		public string ParentDeptId
		{
			get;
			set;
		}
	}
}
