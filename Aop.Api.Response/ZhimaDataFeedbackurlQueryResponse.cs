using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaDataFeedbackurlQueryResponse : AopResponse
	{
		[XmlElement("feedback_url")]
		public string FeedbackUrl
		{
			get;
			set;
		}
	}
}
