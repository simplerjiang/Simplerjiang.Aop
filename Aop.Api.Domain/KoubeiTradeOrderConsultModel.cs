using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiTradeOrderConsultModel : AopObject
	{
		[XmlElement("apdid_token")]
		public string ApdidToken
		{
			get;
			set;
		}

		[XmlArray("goods_info")]
		[XmlArrayItem("goods_info")]
		public List<GoodsInfo> GoodsInfo
		{
			get;
			set;
		}

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}

		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}

		[XmlElement("total_amount")]
		public string TotalAmount
		{
			get;
			set;
		}

		[XmlElement("undiscountable_amount")]
		public string UndiscountableAmount
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
