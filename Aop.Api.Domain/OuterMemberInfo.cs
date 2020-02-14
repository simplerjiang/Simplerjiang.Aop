using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class OuterMemberInfo : AopObject
	{
		[XmlElement("user_info")]
		public string UserInfo
		{
			get;
			set;
		}
	}
}
