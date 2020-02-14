using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceCityfacilitatorVoucherBatchqueryModel : AopObject
	{
		[XmlElement("city_code")]
		public string CityCode
		{
			get;
			set;
		}

		[XmlArray("trade_nos")]
		[XmlArrayItem("string")]
		public List<string> TradeNos
		{
			get;
			set;
		}
	}
}
