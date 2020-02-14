using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class OrderLogisticsInfo : AopObject
	{
		[XmlElement("address")]
		public string Address
		{
			get;
			set;
		}

		[XmlElement("contact_name")]
		public string ContactName
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public OrderLogisticsExtInfo ExtInfo
		{
			get;
			set;
		}

		[XmlElement("latitude")]
		public string Latitude
		{
			get;
			set;
		}

		[XmlElement("longitude")]
		public string Longitude
		{
			get;
			set;
		}

		[XmlElement("merchant_bind_mobile")]
		public string MerchantBindMobile
		{
			get;
			set;
		}

		[XmlElement("mobile")]
		public string Mobile
		{
			get;
			set;
		}
	}
}
