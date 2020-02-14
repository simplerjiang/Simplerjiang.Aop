using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringCrowdgroupConditionQueryResponse : AopResponse
	{
		[XmlArray("condition_list")]
		[XmlArrayItem("user_crowd_conditions")]
		public List<UserCrowdConditions> ConditionList
		{
			get;
			set;
		}
	}
}
