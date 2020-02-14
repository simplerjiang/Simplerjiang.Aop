using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarMerchantshopCommentBatchqueryResponse : AopResponse
	{
		[XmlArray("comment_result")]
		[XmlArrayItem("merchantshop_comment_result")]
		public List<MerchantshopCommentResult> CommentResult
		{
			get;
			set;
		}

		[XmlElement("comment_statistic")]
		public MerchantshopCommentStatistic CommentStatistic
		{
			get;
			set;
		}
	}
}
