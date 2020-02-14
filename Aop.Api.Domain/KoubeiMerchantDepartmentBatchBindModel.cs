using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMerchantDepartmentBatchBindModel : AopObject
	{
		[XmlElement("auth_code")]
		public string AuthCode
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

		[XmlElement("dept_type")]
		public string DeptType
		{
			get;
			set;
		}

		[XmlArray("operator_list")]
		[XmlArrayItem("simple_operator_model")]
		public List<SimpleOperatorModel> OperatorList
		{
			get;
			set;
		}
	}
}
