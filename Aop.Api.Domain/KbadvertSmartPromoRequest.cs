using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbadvertSmartPromoRequest : AopObject
	{
		[XmlElement("group_id")]
		public string GroupId
		{
			get;
			set;
		}

		[XmlElement("plan_id")]
		public string PlanId
		{
			get;
			set;
		}
	}
}
