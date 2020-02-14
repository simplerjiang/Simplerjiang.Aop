using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceTransportOfflinepayVirtualcardSendModel : AopObject
	{
		[XmlElement("action")]
		public string Action
		{
			get;
			set;
		}

		[XmlElement("balance")]
		public string Balance
		{
			get;
			set;
		}

		[XmlElement("card_data")]
		public string CardData
		{
			get;
			set;
		}

		[XmlElement("card_no")]
		public string CardNo
		{
			get;
			set;
		}

		[XmlElement("card_type")]
		public string CardType
		{
			get;
			set;
		}

		[XmlElement("disabled")]
		public string Disabled
		{
			get;
			set;
		}

		[XmlElement("disabled_code")]
		public string DisabledCode
		{
			get;
			set;
		}

		[XmlElement("disabled_tips")]
		public string DisabledTips
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("last_update_time")]
		public string LastUpdateTime
		{
			get;
			set;
		}

		[XmlElement("trade_scene")]
		public string TradeScene
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
