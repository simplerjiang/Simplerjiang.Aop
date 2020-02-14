using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AntMerchantExpandAutomatApplyModifyResponse : AopResponse
	{
		[XmlElement("alipay_terminal_id")]
		public string AlipayTerminalId
		{
			get;
			set;
		}
	}
}
