using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InteligentConstraintInfo : AopObject
	{
		[XmlElement("crowd_group_id")]
		public string CrowdGroupId
		{
			get;
			set;
		}

		[XmlElement("item_ids")]
		public string ItemIds
		{
			get;
			set;
		}

		[XmlElement("min_cost")]
		public string MinCost
		{
			get;
			set;
		}

		[XmlArray("suit_shops")]
		[XmlArrayItem("string")]
		public List<string> SuitShops
		{
			get;
			set;
		}

		[XmlElement("user_win_count")]
		public string UserWinCount
		{
			get;
			set;
		}

		[XmlElement("user_win_frequency")]
		public string UserWinFrequency
		{
			get;
			set;
		}
	}
}
