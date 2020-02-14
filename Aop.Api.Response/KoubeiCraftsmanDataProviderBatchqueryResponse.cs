using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCraftsmanDataProviderBatchqueryResponse : AopResponse
	{
		[XmlArray("craftsmans")]
		[XmlArrayItem("craftsman_open_model")]
		public List<CraftsmanOpenModel> Craftsmans
		{
			get;
			set;
		}

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

		[XmlElement("total_craftsmans")]
		public long TotalCraftsmans
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
	}
}
