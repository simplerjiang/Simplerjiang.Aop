using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ContactFollower : AopObject
	{
		[XmlElement("avatar")]
		public string Avatar
		{
			get;
			set;
		}

		[XmlElement("default_avatar")]
		public string DefaultAvatar
		{
			get;
			set;
		}

		[XmlElement("each_record_flag")]
		public string EachRecordFlag
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
