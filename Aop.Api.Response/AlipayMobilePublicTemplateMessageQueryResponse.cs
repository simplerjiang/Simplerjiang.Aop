using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobilePublicTemplateMessageQueryResponse : AopResponse
	{
		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}
	}
}
