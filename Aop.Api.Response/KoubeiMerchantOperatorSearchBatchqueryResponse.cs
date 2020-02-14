using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMerchantOperatorSearchBatchqueryResponse : AopResponse
	{
		[XmlElement("current_page")]
		public long CurrentPage
		{
			get;
			set;
		}

		[XmlArray("operator_info_models")]
		[XmlArrayItem("operator_info_model")]
		public List<OperatorInfoModel> OperatorInfoModels
		{
			get;
			set;
		}

		[XmlElement("total_items")]
		public long TotalItems
		{
			get;
			set;
		}

		[XmlElement("total_pages")]
		public long TotalPages
		{
			get;
			set;
		}
	}
}
