using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySocialBaseChatGmemberDeleteResponse : AopResponse
	{
		[XmlElement("result_delete")]
		public bool ResultDelete
		{
			get;
			set;
		}
	}
}
