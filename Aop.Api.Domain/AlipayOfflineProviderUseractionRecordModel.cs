using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOfflineProviderUseractionRecordModel : AopObject
	{
		[XmlElement("action_detail")]
		public string ActionDetail
		{
			get;
			set;
		}

		[XmlElement("action_outer_id")]
		public string ActionOuterId
		{
			get;
			set;
		}

		[XmlElement("action_type")]
		public string ActionType
		{
			get;
			set;
		}

		[XmlElement("alipay_app_id")]
		public string AlipayAppId
		{
			get;
			set;
		}

		[XmlElement("date_time")]
		public string DateTime
		{
			get;
			set;
		}

		[XmlElement("entity")]
		public string Entity
		{
			get;
			set;
		}

		[XmlElement("industry")]
		public string Industry
		{
			get;
			set;
		}

		[XmlElement("mobile")]
		public string Mobile
		{
			get;
			set;
		}

		[XmlElement("order_channel")]
		public string OrderChannel
		{
			get;
			set;
		}

		[XmlElement("order_type")]
		public string OrderType
		{
			get;
			set;
		}

		[XmlElement("outer_shop_do")]
		public OuterShopDO OuterShopDo
		{
			get;
			set;
		}

		[XmlElement("platform_user_id")]
		public string PlatformUserId
		{
			get;
			set;
		}

		[XmlElement("source")]
		public string Source
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
	}
}
