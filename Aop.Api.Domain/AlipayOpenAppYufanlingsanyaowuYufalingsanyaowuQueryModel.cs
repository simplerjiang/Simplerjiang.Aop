using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenAppYufanlingsanyaowuYufalingsanyaowuQueryModel : AopObject
	{
		[XmlArray("province_code")]
		[XmlArrayItem("string")]
		public List<string> ProvinceCode
		{
			get;
			set;
		}
	}
}
