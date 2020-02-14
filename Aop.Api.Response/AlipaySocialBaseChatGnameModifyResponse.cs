using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySocialBaseChatGnameModifyResponse : AopResponse
	{
		[XmlElement("result_modify")]
		public bool ResultModify
		{
			get;
			set;
		}
	}
}
