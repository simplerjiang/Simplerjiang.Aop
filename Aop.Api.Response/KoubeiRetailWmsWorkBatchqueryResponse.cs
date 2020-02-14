using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailWmsWorkBatchqueryResponse : AopResponse
	{
		[XmlElement("page_no")]
		public string PageNo
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

		[XmlArray("work_list")]
		[XmlArrayItem("work_list_v_o")]
		public List<WorkListVO> WorkList
		{
			get;
			set;
		}
	}
}
