using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayExscUserFirstsignGetResponse : AopResponse
	{
		[XmlElement("biz_type")]
		public string BizType
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
