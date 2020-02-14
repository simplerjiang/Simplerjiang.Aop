using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataShopCategoryGetResponse : AopResponse
	{
		[XmlArray("category_list")]
		[XmlArrayItem("category")]
		public List<Category> CategoryList
		{
			get;
			set;
		}

		[XmlElement("other")]
		public Category Other
		{
			get;
			set;
		}
	}
}
