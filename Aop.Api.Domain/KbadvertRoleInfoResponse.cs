using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbadvertRoleInfoResponse : AopObject
	{
		[XmlElement("role_code")]
		public string RoleCode
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
	}
}
