using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PublicMessageInfo : AopObject
	{
		[XmlElement("message_id")]
		public string MessageId
		{
			get;
			set;
		}

		[XmlElement("send_time")]
		public string SendTime
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("status_desc")]
		public string StatusDesc
		{
			get;
			set;
		}
	}
}
