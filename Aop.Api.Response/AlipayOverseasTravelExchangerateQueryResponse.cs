using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOverseasTravelExchangerateQueryResponse : AopResponse
	{
		[XmlElement("currency")]
		public string Currency
		{
			get;
			set;
		}

		[XmlElement("currency_icon")]
		public string CurrencyIcon
		{
			get;
			set;
		}

		[XmlElement("customer_level")]
		public string CustomerLevel
		{
			get;
			set;
		}

		[XmlElement("rate")]
		public string Rate
		{
			get;
			set;
		}

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
	}
}
