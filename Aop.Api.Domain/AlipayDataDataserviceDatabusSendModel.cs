using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayDataDataserviceDatabusSendModel : AopObject
	{
		[XmlElement("event_code")]
		public string EventCode
		{
			get;
			set;
		}

		[XmlElement("event_payload")]
		public string EventPayload
		{
			get;
			set;
		}

		[XmlElement("payload_class")]
		public string PayloadClass
		{
			get;
			set;
		}

		[XmlElement("topic")]
		public string Topic
		{
			get;
			set;
		}
	}
}
