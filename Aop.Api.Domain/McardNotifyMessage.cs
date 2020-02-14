using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class McardNotifyMessage : AopObject
	{
		[XmlElement("change_reason")]
		public string ChangeReason
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

		[XmlElement("message_type")]
		public string MessageType
		{
			get;
			set;
		}
	}
}
