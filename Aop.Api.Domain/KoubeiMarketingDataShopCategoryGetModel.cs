using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingDataShopCategoryGetModel : AopObject
	{
		[XmlElement("count")]
		public long Count
		{
			get;
			set;
		}

		[XmlElement("mall_id")]
		public string MallId
		{
			get;
			set;
		}
	}
}
