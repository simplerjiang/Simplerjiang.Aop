using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringCrowdgroupConditionSetModel : AopObject
	{
		[XmlArray("condition_model_list")]
		[XmlArrayItem("condition_item_pattern")]
		public List<ConditionItemPattern> ConditionModelList
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

		[XmlElement("describe")]
		public string Describe
		{
			get;
			set;
		}

		[XmlElement("operation")]
		public string Operation
		{
			get;
			set;
		}

		[XmlElement("operator_id")]
		public string OperatorId
		{
			get;
			set;
		}

		[XmlElement("operator_type")]
		public string OperatorType
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
