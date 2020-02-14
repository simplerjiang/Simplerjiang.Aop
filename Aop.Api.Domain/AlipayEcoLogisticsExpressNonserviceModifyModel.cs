using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoLogisticsExpressNonserviceModifyModel : AopObject
	{
		[XmlArray("area_codes")]
		[XmlArrayItem("area_code")]
		public List<AreaCode> AreaCodes
		{
			get;
			set;
		}

		[XmlElement("logis_merch_code")]
		public string LogisMerchCode
		{
			get;
			set;
		}
	}
}
