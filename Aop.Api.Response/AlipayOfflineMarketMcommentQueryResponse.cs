using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOfflineMarketMcommentQueryResponse : AopResponse
	{
		[XmlElement("comment_id")]
		public string CommentId
		{
			get;
			set;
		}

		[XmlElement("comment_status")]
		public string CommentStatus
		{
			get;
			set;
		}

		[XmlElement("comment_time")]
		public string CommentTime
		{
			get;
			set;
		}

		[XmlElement("score")]
		public long Score
		{
			get;
			set;
		}
	}
}
