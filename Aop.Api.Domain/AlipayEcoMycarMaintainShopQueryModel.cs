using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarMaintainShopQueryModel : AopObject
	{
		[XmlElement("out_shop_id")]
		public string OutShopId
		{
			get;
			set;
		}

		[XmlElement("shop_id")]
		public long ShopId
		{
			get;
			set;
		}
	}
}
