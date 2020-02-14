using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicMatchuserLabelDeleteResponse : AopResponse
	{
		[XmlElement("error_count")]
		public long ErrorCount
		{
			get;
			set;
		}

		[XmlArray("error_matchers")]
		[XmlArrayItem("error_matcher")]
		public List<ErrorMatcher> ErrorMatchers
		{
			get;
			set;
		}
	}
}
