using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCreditAutofinanceVidGetResponse : AopResponse
	{
		[XmlElement("verifyid")]
		public string Verifyid
		{
			get;
			set;
		}
	}
}
