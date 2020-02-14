using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCampaignDrawcampTriggerModel : AopObject
	{
		[XmlElement("bind_mobile")]
		public string BindMobile
		{
			get;
			set;
		}

		[XmlElement("camp_id")]
		public string CampId
		{
			get;
			set;
		}

		[XmlElement("camp_source")]
		public long CampSource
		{
			get;
			set;
		}

		[XmlElement("channel_info")]
		public string ChannelInfo
		{
			get;
			set;
		}

		[XmlElement("client_ip")]
		public string ClientIp
		{
			get;
			set;
		}

		[XmlElement("json_ua")]
		public string JsonUa
		{
			get;
			set;
		}

		[XmlElement("login_id")]
		public string LoginId
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
