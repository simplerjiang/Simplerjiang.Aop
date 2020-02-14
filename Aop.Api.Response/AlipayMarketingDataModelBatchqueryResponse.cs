using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingDataModelBatchqueryResponse : AopResponse
	{
		[XmlArray("model_meta")]
		[XmlArrayItem("model_meta")]
		public List<ModelMeta> ModelMeta
		{
			get;
			set;
		}

		[XmlElement("total_page_count")]
		public string TotalPageCount
		{
			get;
			set;
		}
	}
}
