using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InfoCode : AopObject
	{
		[XmlElement("risk_description")]
		public string RiskDescription
		{
			get;
			set;
		}

		[XmlElement("risk_factor_code")]
		public string RiskFactorCode
		{
			get;
			set;
		}

		[XmlElement("risk_factor_name")]
		public string RiskFactorName
		{
			get;
			set;
		}

		[XmlElement("risk_magnitude")]
		public string RiskMagnitude
		{
			get;
			set;
		}
	}
}
