using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityRiskDirectionalRainscoreQueryModel : AopObject
	{
		[XmlElement("account")]
		public string Account
		{
			get;
			set;
		}

		[XmlElement("account_type")]
		public string AccountType
		{
			get;
			set;
		}

		[XmlElement("version")]
		public string Version
		{
			get;
			set;
		}
	}
}
