using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class GoodsInfo : AopObject
	{
		[XmlElement("goods_category")]
		public string GoodsCategory
		{
			get;
			set;
		}

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

		[XmlElement("price")]
		public string Price
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
	}
}
