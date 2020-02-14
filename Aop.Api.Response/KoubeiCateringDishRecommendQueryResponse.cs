using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringDishRecommendQueryResponse : AopResponse
	{
		[XmlArray("dish_list")]
		[XmlArrayItem("dish_recommend")]
		public List<DishRecommend> DishList
		{
			get;
			set;
		}
	}
}
