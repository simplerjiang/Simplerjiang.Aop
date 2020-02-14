using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class GroupMemberInfo : AopObject
	{
		[XmlElement("group_nickname")]
		public string GroupNickname
		{
			get;
			set;
		}

		[XmlElement("nickname")]
		public string Nickname
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
