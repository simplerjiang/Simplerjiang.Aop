using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySocialBaseGroupmemberAddModel : AopObject
	{
		[XmlElement("friend_validate")]
		public bool FriendValidate
		{
			get;
			set;
		}

		[XmlElement("group_id")]
		public string GroupId
		{
			get;
			set;
		}

		[XmlArray("user_ids")]
		[XmlArrayItem("string")]
		public List<string> UserIds
		{
			get;
			set;
		}
	}
}
