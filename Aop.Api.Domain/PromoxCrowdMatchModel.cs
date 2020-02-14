using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PromoxCrowdMatchModel : AopObject
	{
		[XmlElement("crowd_code")]
		public string CrowdCode
		{
			get;
			set;
		}

		[XmlElement("is_match")]
		public bool IsMatch
		{
			get;
			set;
		}
	}
}
