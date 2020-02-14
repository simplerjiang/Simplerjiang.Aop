using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarMaintainServiceproductUpdateModel : AopObject
	{
		[XmlElement("operation_type")]
		public string OperationType
		{
			get;
			set;
		}

		[XmlElement("out_product_id")]
		public string OutProductId
		{
			get;
			set;
		}

		[XmlElement("shop_product")]
		public MaitainShopProduct ShopProduct
		{
			get;
			set;
		}
	}
}
