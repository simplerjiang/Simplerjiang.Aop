using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMerchantRole : AopObject
	{
		[XmlElement("operator_num")]
		public string OperatorNum
		{
			get;
			set;
		}

		[XmlElement("permission_num")]
		public string PermissionNum
		{
			get;
			set;
		}

		[XmlElement("role_code")]
		public string RoleCode
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

		[XmlElement("role_name")]
		public string RoleName
		{
			get;
			set;
		}
	}
}
