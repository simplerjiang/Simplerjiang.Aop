using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMerchantDeviceCrashinfoUploadModel : AopObject
	{
		[XmlElement("event_time")]
		public string EventTime
		{
			get;
			set;
		}

		[XmlElement("extend_info")]
		public string ExtendInfo
		{
			get;
			set;
		}

		[XmlElement("hardware_version")]
		public string HardwareVersion
		{
			get;
			set;
		}

		[XmlElement("log_time")]
		public string LogTime
		{
			get;
			set;
		}

		[XmlElement("message_type")]
		public string MessageType
		{
			get;
			set;
		}

		[XmlElement("product")]
		public string Product
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

		[XmlElement("sn_id")]
		public string SnId
		{
			get;
			set;
		}
	}
}
