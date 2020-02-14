using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DepartmentDTO : AopObject
	{
		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("dept_id")]
		public string DeptId
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

		[XmlElement("dept_path")]
		public string DeptPath
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

		[XmlElement("label_name")]
		public string LabelName
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

		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}
	}
}
