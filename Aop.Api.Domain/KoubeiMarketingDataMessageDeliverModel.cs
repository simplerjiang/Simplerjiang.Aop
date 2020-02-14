using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingDataMessageDeliverModel : AopObject
	{
		[XmlElement("content")]
		public string Content
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

		[XmlElement("msg_type")]
		public string MsgType
		{
			get;
			set;
		}
	}
}
