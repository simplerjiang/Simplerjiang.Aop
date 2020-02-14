using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySocialBaseChatGinvSendResponse : AopResponse
	{
		[XmlElement("result_tip")]
		public string ResultTip
		{
			get;
			set;
		}
	}
}
