using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiAdvertDeliveryItemApplyModel : AopObject
	{
		[XmlElement("adv_id")]
		public string AdvId
		{
			get;
			set;
		}

		[XmlElement("channel_code")]
		public string ChannelCode
		{
			get;
			set;
		}

		[XmlElement("channel_id")]
		public string ChannelId
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("recommend_id")]
		public string RecommendId
		{
			get;
			set;
		}

		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}

		[XmlElement("tag")]
		public string Tag
		{
			get;
			set;
		}
	}
}
