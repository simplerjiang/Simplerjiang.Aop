using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsUnderwriteUserPolicyQueryModel : AopObject
	{
		[XmlElement("page_no")]
		public long PageNo
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public long PageSize
		{
			get;
			set;
		}

		[XmlElement("person")]
		public InsQueryPerson Person
		{
			get;
			set;
		}

		[XmlArray("product_list")]
		[XmlArrayItem("string")]
		public List<string> ProductList
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
