using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingDataTradeHabbitQueryModel : AopObject
	{
		[XmlElement("biz_date")]
		public string BizDate
		{
			get;
			set;
		}

		[XmlElement("store_ids")]
		public string StoreIds
		{
			get;
			set;
		}
	}
}
