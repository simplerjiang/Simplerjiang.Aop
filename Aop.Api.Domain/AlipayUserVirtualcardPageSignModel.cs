using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserVirtualcardPageSignModel : AopObject
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

		[XmlElement("card_sign_mode")]
		public string CardSignMode
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

		[XmlElement("disabled_tips")]
		public string DisabledTips
		{
			get;
			set;
		}

		[XmlElement("disabled_url")]
		public string DisabledUrl
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
	}
}
