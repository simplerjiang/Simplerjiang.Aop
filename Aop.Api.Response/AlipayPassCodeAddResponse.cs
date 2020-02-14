using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayPassCodeAddResponse : AopResponse
	{
		[XmlArray("biz_result")]
		[XmlArrayItem("string")]
		public List<string> BizResult
		{
			get;
			set;
		}

		[XmlElement("error_code")]
		public string ErrorCode
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
