using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOfflineProviderShopactionRecordModel : AopObject
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

		[XmlElement("outer_shop_do")]
		public OuterShopDO OuterShopDo
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
