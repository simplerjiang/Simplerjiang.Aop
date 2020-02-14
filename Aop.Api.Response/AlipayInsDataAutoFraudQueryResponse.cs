using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsDataAutoFraudQueryResponse : AopResponse
	{
		[XmlElement("fraud_tag")]
		public string FraudTag
		{
			get;
			set;
		}

		[XmlElement("fraud_tag_level")]
		public string FraudTagLevel
		{
			get;
			set;
		}

		[XmlArray("info_code_list")]
		[XmlArrayItem("case_info_code")]
		public List<CaseInfoCode> InfoCodeList
		{
			get;
			set;
		}
	}
}
