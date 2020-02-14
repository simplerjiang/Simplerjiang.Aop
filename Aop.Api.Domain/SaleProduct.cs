using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SaleProduct : AopObject
	{
		[XmlElement("channel_type")]
		public string ChannelType
		{
			get;
			set;
		}

		[XmlElement("id")]
		public string Id
		{
			get;
			set;
		}

		[XmlElement("market_price")]
		public string MarketPrice
		{
			get;
			set;
		}

		[XmlElement("product_provider")]
		public ProductProvider ProductProvider
		{
			get;
			set;
		}

		[XmlElement("sale_price")]
		public string SalePrice
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
