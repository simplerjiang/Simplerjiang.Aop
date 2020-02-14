using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityRiskPolicyQueryModel : AopObject
	{
		[XmlElement("risk_type")]
		public string RiskType
		{
			get;
			set;
		}

		[XmlElement("security_scene")]
		public SecurityScene SecurityScene
		{
			get;
			set;
		}

		[XmlElement("service_context")]
		public ServiceContext ServiceContext
		{
			get;
			set;
		}
	}
}
