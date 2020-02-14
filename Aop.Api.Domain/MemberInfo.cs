using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MemberInfo : AopObject
	{
		[XmlElement("gender")]
		public string Gender
		{
			get;
			set;
		}

		[XmlElement("group_nick_name")]
		public string GroupNickName
		{
			get;
			set;
		}

		[XmlElement("inviter_uid")]
		public string InviterUid
		{
			get;
			set;
		}

		[XmlElement("member_img")]
		public string MemberImg
		{
			get;
			set;
		}

		[XmlElement("nick_name")]
		public string NickName
		{
			get;
			set;
		}

		[XmlElement("uid")]
		public string Uid
		{
			get;
			set;
		}
	}
}
