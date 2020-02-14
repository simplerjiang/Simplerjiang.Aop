using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailWmsCategoryQueryResponse : AopResponse
	{
		[XmlElement("category")]
		public CategoryVO Category
		{
			get;
			set;
		}

		[XmlArray("sub_categories")]
		[XmlArrayItem("category_v_o")]
		public List<CategoryVO> SubCategories
		{
			get;
			set;
		}
	}
}
