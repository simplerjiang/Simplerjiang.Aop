using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiItemCategoryChildrenBatchqueryResponse : AopResponse
	{
		[XmlArray("category_list")]
		[XmlArrayItem("standard_category_info")]
		public List<StandardCategoryInfo> CategoryList
		{
			get;
			set;
		}
	}
}
