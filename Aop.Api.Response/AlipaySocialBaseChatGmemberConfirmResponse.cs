using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySocialBaseChatGmemberConfirmResponse : AopResponse
	{
		[XmlElement("group_id")]
		public string GroupId
		{
			get;
			set;
		}

		[XmlElement("result")]
		public bool Result
		{
			get;
			set;
		}
	}
}
