using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringCommodityOrderBuyModel : AopObject
	{
		[XmlElement("agent_id")]
		public string AgentId
		{
			get;
			set;
		}

		[XmlElement("agent_type")]
		public string AgentType
		{
			get;
			set;
		}

		[XmlElement("consumer_card_no")]
		public string ConsumerCardNo
		{
			get;
			set;
		}

		[XmlElement("merchandise_id")]
		public string MerchandiseId
		{
			get;
			set;
		}

		[XmlArray("shop_ids")]
		[XmlArrayItem("string")]
		public List<string> ShopIds
		{
			get;
			set;
		}
	}
}
