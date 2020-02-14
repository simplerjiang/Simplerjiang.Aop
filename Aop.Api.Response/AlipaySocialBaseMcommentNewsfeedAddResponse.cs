using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySocialBaseMcommentNewsfeedAddResponse : AopResponse
	{
		[XmlElement("newsfeed_id")]
		public string NewsfeedId
		{
			get;
			set;
		}
	}
}
