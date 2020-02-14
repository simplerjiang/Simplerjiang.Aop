using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarFuellingProductModifyModel : AopObject
	{
		[XmlElement("out_shop_id")]
		public string OutShopId
		{
			get;
			set;
		}

		[XmlArray("product")]
		[XmlArrayItem("product")]
		public List<Product> Product
		{
			get;
			set;
		}

		[XmlArray("sale")]
		[XmlArrayItem("sale")]
		public List<Sale> Sale
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
	}
}
