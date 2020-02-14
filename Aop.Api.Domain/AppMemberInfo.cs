using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AppMemberInfo : AopObject
	{
		[XmlElement("gmt_invite")]
		public string GmtInvite
		{
			get;
			set;
		}

		[XmlElement("gmt_join")]
		public string GmtJoin
		{
			get;
			set;
		}

		[XmlElement("logon_id")]
		public string LogonId
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

		[XmlElement("portrait")]
		public string Portrait
		{
			get;
			set;
		}

		[XmlElement("role")]
		public string Role
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

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
