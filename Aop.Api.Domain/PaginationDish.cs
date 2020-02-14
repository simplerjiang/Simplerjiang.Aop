using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PaginationDish : AopObject
	{
		[XmlArray("list")]
		[XmlArrayItem("kbdish_info")]
		public List<KbdishInfo> List
		{
			get;
			set;
		}

		[XmlElement("page_no")]
		public string PageNo
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

		[XmlElement("total_count")]
		public string TotalCount
		{
			get;
			set;
		}

		[XmlElement("total_page")]
		public string TotalPage
		{
			get;
			set;
		}
	}
}
