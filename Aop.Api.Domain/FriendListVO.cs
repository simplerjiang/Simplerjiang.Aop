using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FriendListVO : AopObject
	{
		[XmlElement("head_img")]
		public string HeadImg
		{
			get;
			set;
		}

		[XmlElement("real_friend")]
		public bool RealFriend
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

		[XmlElement("view_name")]
		public string ViewName
		{
			get;
			set;
		}
	}
}
