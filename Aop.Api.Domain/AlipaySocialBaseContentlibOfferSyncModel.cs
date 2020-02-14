using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySocialBaseContentlibOfferSyncModel : AopObject
	{
		[XmlElement("channel_id")]
		public string ChannelId
		{
			get;
			set;
		}

		[XmlElement("display_app")]
		public OfferObject DisplayApp
		{
			get;
			set;
		}

		[XmlElement("operate_type")]
		public string OperateType
		{
			get;
			set;
		}
	}
}
