using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityRiskPolicyRdsQueryModel : AopObject
	{
		[XmlElement("rds_params")]
		public string RdsParams
		{
			get;
			set;
		}
	}
}
