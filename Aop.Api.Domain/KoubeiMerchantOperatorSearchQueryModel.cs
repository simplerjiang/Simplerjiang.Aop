using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMerchantOperatorSearchQueryModel : AopObject
	{
		[XmlElement("auth_code")]
		public string AuthCode
		{
			get;
			set;
		}

		[XmlArray("dept_ids")]
		[XmlArrayItem("string")]
		public List<string> DeptIds
		{
			get;
			set;
		}

		[XmlArray("dept_paths")]
		[XmlArrayItem("string")]
		public List<string> DeptPaths
		{
			get;
			set;
		}

		[XmlElement("page_num")]
		public long PageNum
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public string PageSize
		{
			get;
			set;
		}

		[XmlArray("role_ids")]
		[XmlArrayItem("string")]
		public List<string> RoleIds
		{
			get;
			set;
		}

		[XmlElement("search_key")]
		public string SearchKey
		{
			get;
			set;
		}

		[XmlArray("status")]
		[XmlArrayItem("string")]
		public List<string> Status
		{
			get;
			set;
		}

		[XmlElement("unassign")]
		public bool Unassign
		{
			get;
			set;
		}
	}
}
