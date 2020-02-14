using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsClaimPolicy : AopObject
	{
		[XmlElement("policy_no")]
		public string PolicyNo
		{
			get;
			set;
		}
	}
}
