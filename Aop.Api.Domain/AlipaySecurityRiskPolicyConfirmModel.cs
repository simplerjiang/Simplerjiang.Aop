using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityRiskPolicyConfirmModel : AopObject
	{
		[XmlElement("confirm_params")]
		public string ConfirmParams
		{
			get;
			set;
		}

		[XmlElement("security_id")]
		public string SecurityId
		{
			get;
			set;
		}
	}
}
