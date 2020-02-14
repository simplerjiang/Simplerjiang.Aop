using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayQueryCardModelResult : AopObject
	{
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

		[XmlElement("card_status")]
		public string CardStatus
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

		[XmlElement("status_code")]
		public string StatusCode
		{
			get;
			set;
		}

		[XmlElement("status_msg")]
		public string StatusMsg
		{
			get;
			set;
		}

		[XmlElement("user_auth_info")]
		public string UserAuthInfo
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
