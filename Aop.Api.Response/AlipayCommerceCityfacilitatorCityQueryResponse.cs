using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceCityfacilitatorCityQueryResponse : AopResponse
	{
		[XmlArray("citys")]
		[XmlArrayItem("city_function")]
		public List<CityFunction> Citys
		{
			get;
			set;
		}
	}
}
