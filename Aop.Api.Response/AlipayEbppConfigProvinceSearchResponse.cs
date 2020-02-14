using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppConfigProvinceSearchResponse : AopResponse
	{
		[XmlArray("area_info_result")]
		[XmlArrayItem("area_info")]
		public List<AreaInfo> AreaInfoResult
		{
			get;
			set;
		}
	}
}
