using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayDataAiserviceSmartpriceGetModel : AopObject
	{
		[XmlElement("base_price_cent")]
		public long BasePriceCent
		{
			get;
			set;
		}

		[XmlElement("channel")]
		public string Channel
		{
			get;
			set;
		}

		[XmlElement("city_code")]
		public string CityCode
		{
			get;
			set;
		}

		[XmlElement("default_promo_price_cent")]
		public long DefaultPromoPriceCent
		{
			get;
			set;
		}

		[XmlElement("from")]
		public string From
		{
			get;
			set;
		}

		[XmlElement("high_price_cent")]
		public long HighPriceCent
		{
			get;
			set;
		}

		[XmlElement("lower_price_cent")]
		public long LowerPriceCent
		{
			get;
			set;
		}

		[XmlElement("trace_id")]
		public string TraceId
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
