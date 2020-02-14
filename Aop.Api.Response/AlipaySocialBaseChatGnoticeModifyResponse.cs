using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySocialBaseChatGnoticeModifyResponse : AopResponse
	{
		[XmlElement("result_modify")]
		public string ResultModify
		{
			get;
			set;
		}
	}
}
