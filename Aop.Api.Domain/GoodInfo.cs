using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class GoodInfo : AopObject
	{
		[XmlElement("goods_id")]
		public string GoodsId
		{
			get;
			set;
		}

		[XmlElement("goods_name")]
		public string GoodsName
		{
			get;
			set;
		}

		[XmlElement("quantity")]
		public string Quantity
		{
			get;
			set;
		}

		[XmlElement("weight")]
		public string Weight
		{
			get;
			set;
		}
	}
}
