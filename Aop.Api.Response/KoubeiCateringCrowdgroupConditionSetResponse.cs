using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringCrowdgroupConditionSetResponse : AopResponse
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

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
