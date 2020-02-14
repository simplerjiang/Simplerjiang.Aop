using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOverseasTravelExchangerateBatchqueryResponse : AopResponse
	{
		[XmlElement("rate_desc")]
		public string RateDesc
		{
			get;
			set;
		}

		[XmlElement("rate_source")]
		public string RateSource
		{
			get;
			set;
		}

		[XmlArray("rates")]
		[XmlArrayItem("overseas_travel_rate")]
		public List<OverseasTravelRate> Rates
		{
			get;
			set;
		}
	}
}
