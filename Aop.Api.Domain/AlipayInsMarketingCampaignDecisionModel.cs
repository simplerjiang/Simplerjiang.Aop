using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsMarketingCampaignDecisionModel : AopObject
	{
		[XmlElement("business_type")]
		public long BusinessType
		{
			get;
			set;
		}

		[XmlArray("market_types")]
		[XmlArrayItem("number")]
		public List<long> MarketTypes
		{
			get;
			set;
		}

		[XmlElement("mkt_obj_id")]
		public string MktObjId
		{
			get;
			set;
		}

		[XmlElement("mkt_obj_type")]
		public long MktObjType
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
	}
}
