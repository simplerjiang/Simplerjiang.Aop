using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityRiskContentDetectResponse : AopResponse
	{
		[XmlElement("action")]
		public string Action
		{
			get;
			set;
		}

		[XmlArray("keywords")]
		[XmlArrayItem("string")]
		public List<string> Keywords
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
	}
}
