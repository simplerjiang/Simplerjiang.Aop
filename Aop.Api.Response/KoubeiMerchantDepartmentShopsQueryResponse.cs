using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMerchantDepartmentShopsQueryResponse : AopResponse
	{
		[XmlArray("city_shop_models")]
		[XmlArrayItem("city_shop_model")]
		public List<CityShopModel> CityShopModels
		{
			get;
			set;
		}

		[XmlElement("dept_id")]
		public string DeptId
		{
			get;
			set;
		}
	}
}
