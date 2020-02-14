using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class GoodsDetail : AopObject
	{
		[XmlElement("alipay_goods_id")]
		public string AlipayGoodsId
		{
			get;
			set;
		}

		[XmlElement("body")]
		public string Body
		{
			get;
			set;
		}

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
		public long Quantity
		{
			get;
			set;
		}

		[XmlElement("show_url")]
		public string ShowUrl
		{
			get;
			set;
		}
	}
}
