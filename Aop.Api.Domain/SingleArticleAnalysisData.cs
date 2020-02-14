using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SingleArticleAnalysisData : AopObject
	{
		[XmlElement("avg_read_time")]
		public string AvgReadTime
		{
			get;
			set;
		}

		[XmlElement("date")]
		public string Date
		{
			get;
			set;
		}

		[XmlElement("deliver_user_cnt")]
		public long DeliverUserCnt
		{
			get;
			set;
		}

		[XmlElement("expose_user_cnt")]
		public long ExposeUserCnt
		{
			get;
			set;
		}

		[XmlElement("praise_user_cnt")]
		public long PraiseUserCnt
		{
			get;
			set;
		}

		[XmlElement("read_user_cnt")]
		public long ReadUserCnt
		{
			get;
			set;
		}

		[XmlElement("reply_user_cnt")]
		public long ReplyUserCnt
		{
			get;
			set;
		}

		[XmlElement("share_user_cnt")]
		public long ShareUserCnt
		{
			get;
			set;
		}

		[XmlElement("title")]
		public string Title
		{
			get;
			set;
		}
	}
}
