using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MerchantScreenHit : AopObject
	{
		[XmlElement("input_type")]
		public string InputType
		{
			get;
			set;
		}

		[XmlElement("risk_detail")]
		public string RiskDetail
		{
			get;
			set;
		}
	}
}
