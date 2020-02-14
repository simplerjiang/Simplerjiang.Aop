using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiItemExtitemBatchqueryResponse : AopResponse
	{
		[XmlArray("model_list")]
		[XmlArrayItem("ext_item")]
		public List<ExtItem> ModelList
		{
			get;
			set;
		}

		[XmlElement("page_num")]
		public string PageNum
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

		[XmlElement("total_size")]
		public string TotalSize
		{
			get;
			set;
		}
	}
}
