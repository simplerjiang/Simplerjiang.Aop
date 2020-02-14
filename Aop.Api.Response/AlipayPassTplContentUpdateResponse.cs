using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayPassTplContentUpdateResponse : AopResponse
	{
		[XmlElement("error_code")]
		public string ErrorCode
		{
			get;
			set;
		}

		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}

		[XmlElement("success")]
		public string Success
		{
			get;
			set;
		}
	}
}
