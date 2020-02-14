using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenAppMembersCreateModel : AopObject
	{
		[XmlElement("logon_id")]
		public string LogonId
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
	}
}
