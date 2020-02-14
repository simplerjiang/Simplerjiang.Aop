using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class UserDetails : AopObject
	{
		[XmlElement("user_change_mobile")]
		public string UserChangeMobile
		{
			get;
			set;
		}

		[XmlElement("user_mobile")]
		public string UserMobile
		{
			get;
			set;
		}

		[XmlElement("user_name")]
		public string UserName
		{
			get;
			set;
		}

		[XmlElement("user_relation")]
		public string UserRelation
		{
			get;
			set;
		}
	}
}
