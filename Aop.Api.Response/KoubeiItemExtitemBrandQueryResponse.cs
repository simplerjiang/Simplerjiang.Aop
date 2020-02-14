using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiItemExtitemBrandQueryResponse : AopResponse
	{
		[XmlArray("brand_list")]
		[XmlArrayItem("ext_brand")]
		public List<ExtBrand> BrandList
		{
			get;
			set;
		}
	}
}
