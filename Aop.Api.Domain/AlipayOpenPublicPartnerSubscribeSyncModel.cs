using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicPartnerSubscribeSyncModel : AopObject
	{
		[XmlElement("accept_msg")]
		public string AcceptMsg
		{
			get;
			set;
		}

		[XmlElement("follow_object_id")]
		public string FollowObjectId
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

		[XmlElement("push_switch")]
		public string PushSwitch
		{
			get;
			set;
		}

		[XmlElement("source_id")]
		public string SourceId
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
