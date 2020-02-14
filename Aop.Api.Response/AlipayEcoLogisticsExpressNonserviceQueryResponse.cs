using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoLogisticsExpressNonserviceQueryResponse : AopResponse
	{
		[XmlArray("area_codes")]
		[XmlArrayItem("area_code")]
		public List<AreaCode> AreaCodes
		{
			get;
			set;
		}
	}
}
