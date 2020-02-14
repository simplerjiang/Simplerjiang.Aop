using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ErrorMatcher : AopObject
	{
		[XmlElement("error_msg")]
		public string ErrorMsg
		{
			get;
			set;
		}

		[XmlElement("matcher")]
		public Matcher Matcher
		{
			get;
			set;
		}
	}
}
