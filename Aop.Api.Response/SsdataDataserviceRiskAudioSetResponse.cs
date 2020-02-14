using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class SsdataDataserviceRiskAudioSetResponse : AopResponse
	{
		[XmlElement("count")]
		public string Count
		{
			get;
			set;
		}

		[XmlArray("keyword_list")]
		[XmlArrayItem("string")]
		public List<string> KeywordList
		{
			get;
			set;
		}

		[XmlElement("success")]
		public bool Success
		{
			get;
			set;
		}
	}
}
