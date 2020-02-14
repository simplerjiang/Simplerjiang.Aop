using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMerchantOperatorRoleQueryModel : AopObject
	{
		[XmlElement("auth_code")]
		public string AuthCode
		{
			get;
			set;
		}

		[XmlElement("role_id")]
		public string RoleId
		{
			get;
			set;
		}
	}
}
