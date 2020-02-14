using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MerchantshopCommentResult : AopObject
	{
		[XmlElement("comment")]
		public string Comment
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

		[XmlElement("face")]
		public string Face
		{
			get;
			set;
		}

		[XmlElement("imgs")]
		public string Imgs
		{
			get;
			set;
		}

		[XmlElement("nick_name")]
		public string NickName
		{
			get;
			set;
		}

		[XmlElement("order_no")]
		public string OrderNo
		{
			get;
			set;
		}

		[XmlElement("reply")]
		public string Reply
		{
			get;
			set;
		}

		[XmlElement("reply_time")]
		public string ReplyTime
		{
			get;
			set;
		}

		[XmlElement("score")]
		public string Score
		{
			get;
			set;
		}

		[XmlElement("shop_id")]
		public long ShopId
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}

		[XmlElement("user_name")]
		public string UserName
		{
			get;
			set;
		}
	}
}
