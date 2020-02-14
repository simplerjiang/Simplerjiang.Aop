using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MerchantshopCommentStatistic : AopObject
	{
		[XmlElement("comment_count")]
		public long CommentCount
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
