using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCardUpdateModel : AopObject
	{
		[XmlElement("card_info")]
		public MerchantCard CardInfo
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

		[XmlElement("mcard_style_info")]
		public McardStylInfo McardStyleInfo
		{
			get;
			set;
		}

		[XmlArray("notify_messages")]
		[XmlArrayItem("mcard_notify_message")]
		public List<McardNotifyMessage> NotifyMessages
		{
			get;
			set;
		}

		[XmlElement("occur_time")]
		public string OccurTime
		{
			get;
			set;
		}

		[XmlElement("target_card_no")]
		public string TargetCardNo
		{
			get;
			set;
		}

		[XmlElement("target_card_no_type")]
		public string TargetCardNoType
		{
			get;
			set;
		}
	}
}
