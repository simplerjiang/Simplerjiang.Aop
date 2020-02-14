using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiAdvertCommissionRoleQueryModel : AopObject
	{
		[XmlElement("role_code")]
		public string RoleCode
		{
			get;
			set;
		}

		[XmlElement("user_identify")]
		public string UserIdentify
		{
			get;
			set;
		}

		[XmlElement("user_identify_type")]
		public string UserIdentifyType
		{
			get;
			set;
		}
	}
}
