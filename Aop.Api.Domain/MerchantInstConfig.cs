using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MerchantInstConfig : AopObject
	{
		[XmlElement("en_name")]
		public string EnName
		{
			get;
			set;
		}

		[XmlElement("order_type")]
		public string OrderType
		{
			get;
			set;
		}

		[XmlElement("scene")]
		public string Scene
		{
			get;
			set;
		}

		[XmlElement("zh_name")]
		public string ZhName
		{
			get;
			set;
		}
	}
}
