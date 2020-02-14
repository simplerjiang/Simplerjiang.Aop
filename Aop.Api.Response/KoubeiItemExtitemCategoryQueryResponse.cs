using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiItemExtitemCategoryQueryResponse : AopResponse
	{
		[XmlArray("category_list")]
		[XmlArrayItem("ext_category")]
		public List<ExtCategory> CategoryList
		{
			get;
			set;
		}
	}
}
