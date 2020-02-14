using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CrowdConstraintInfo : AopObject
	{
		[XmlElement("crowd_condition")]
		public string CrowdCondition
		{
			get;
			set;
		}

		[XmlElement("crowd_name")]
		public string CrowdName
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
	}
}
