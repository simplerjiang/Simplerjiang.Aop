using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCraftsmanDataWorkBatchqueryResponse : AopResponse
	{
		[XmlElement("current_page_no")]
		public long CurrentPageNo
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

		[XmlElement("total_page_no")]
		public long TotalPageNo
		{
			get;
			set;
		}

		[XmlElement("total_works")]
		public long TotalWorks
		{
			get;
			set;
		}

		[XmlArray("works")]
		[XmlArrayItem("craftsman_work_open_model")]
		public List<CraftsmanWorkOpenModel> Works
		{
			get;
			set;
		}
	}
}
