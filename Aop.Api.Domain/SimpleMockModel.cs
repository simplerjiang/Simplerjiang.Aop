using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SimpleMockModel : AopObject
	{
		[XmlElement("count_items")]
		public long CountItems
		{
			get;
			set;
		}

		[XmlElement("happen_time")]
		public string HappenTime
		{
			get;
			set;
		}

		[XmlElement("price_num")]
		public string PriceNum
		{
			get;
			set;
		}

		[XmlElement("right")]
		public bool Right
		{
			get;
			set;
		}

		[XmlElement("trade_no")]
		public string TradeNo
		{
			get;
			set;
		}
	}
}
