using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarOrderRefundResponse : AopResponse
	{
		[XmlElement("err_msg")]
		public string ErrMsg
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
