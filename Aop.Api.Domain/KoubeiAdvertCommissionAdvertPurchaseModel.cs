using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiAdvertCommissionAdvertPurchaseModel : AopObject
	{
		[XmlElement("channel_id")]
		public string ChannelId
		{
			get;
			set;
		}

		[XmlElement("out_unique_id")]
		public string OutUniqueId
		{
			get;
			set;
		}

		[XmlElement("security_code")]
		public string SecurityCode
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

		[XmlArray("trigger_identifies")]
		[XmlArrayItem("string")]
		public List<string> TriggerIdentifies
		{
			get;
			set;
		}

		[XmlElement("trigger_identify_type")]
		public string TriggerIdentifyType
		{
			get;
			set;
		}

		[XmlElement("trigger_strategy")]
		public string TriggerStrategy
		{
			get;
			set;
		}

		[XmlElement("user_identify")]
		public string UserIdentify
		{
			get;
			set;
		}

		[XmlElement("user_identify_type")]
		public string UserIdentifyType
		{
			get;
			set;
		}
	}
}
