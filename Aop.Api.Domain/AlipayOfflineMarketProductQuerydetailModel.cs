using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOfflineMarketProductQuerydetailModel : AopObject
	{
		[XmlElement("item_id")]
		public string ItemId
		{
			get;
			set;
		}

		[XmlElement("op_role")]
		public string OpRole
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
