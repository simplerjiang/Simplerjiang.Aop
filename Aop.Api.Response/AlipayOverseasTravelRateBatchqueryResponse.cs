using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOverseasTravelRateBatchqueryResponse : AopResponse
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

		[XmlElement("rates")]
		public string Rates
		{
			get;
			set;
		}
	}
}
