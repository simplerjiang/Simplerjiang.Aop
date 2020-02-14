using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ConstraintInfo : AopObject
	{
		[XmlElement("cash_pool_id")]
		public string CashPoolId
		{
			get;
			set;
		}

		[XmlElement("crowd_group_id")]
		public string CrowdGroupId
		{
			get;
			set;
		}

		[XmlElement("crowd_restriction")]
		public string CrowdRestriction
		{
			get;
			set;
		}

		[XmlElement("crowd_restriction_value")]
		public string CrowdRestrictionValue
		{
			get;
			set;
		}

		[XmlArray("item_ids")]
		[XmlArrayItem("string")]
		public List<string> ItemIds
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

		[XmlElement("subsidy_percent")]
		public string SubsidyPercent
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
