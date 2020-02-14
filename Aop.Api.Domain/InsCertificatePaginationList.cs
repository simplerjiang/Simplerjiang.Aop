using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsCertificatePaginationList : AopObject
	{
		[XmlElement("current_page")]
		public long CurrentPage
		{
			get;
			set;
		}

		[XmlArray("list")]
		[XmlArrayItem("ins_certificate_api_d_t_o")]
		public List<InsCertificateApiDTO> List
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

		[XmlElement("total_count")]
		public long TotalCount
		{
			get;
			set;
		}

		[XmlElement("total_page_num")]
		public long TotalPageNum
		{
			get;
			set;
		}
	}
}
