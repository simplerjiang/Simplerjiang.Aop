using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class SsdataDataserviceRiskCodeQueryResponse : AopResponse
	{
		[XmlElement("hit")]
		public string Hit
		{
			get;
			set;
		}

		[XmlArray("risk_code")]
		[XmlArrayItem("string")]
		public List<string> RiskCode
		{
			get;
			set;
		}

		[XmlElement("unique_id")]
		public string UniqueId
		{
			get;
			set;
		}

		[XmlArray("verify_code")]
		[XmlArrayItem("string")]
		public List<string> VerifyCode
		{
			get;
			set;
		}
	}
}
