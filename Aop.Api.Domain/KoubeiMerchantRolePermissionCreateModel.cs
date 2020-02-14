using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMerchantRolePermissionCreateModel : AopObject
	{
		[XmlElement("auth_code")]
		public string AuthCode
		{
			get;
			set;
		}

		[XmlArray("permissions_to_add")]
		[XmlArrayItem("business_permission")]
		public List<BusinessPermission> PermissionsToAdd
		{
			get;
			set;
		}

		[XmlArray("permissions_to_delete")]
		[XmlArrayItem("business_permission")]
		public List<BusinessPermission> PermissionsToDelete
		{
			get;
			set;
		}

		[XmlElement("principal_id")]
		public string PrincipalId
		{
			get;
			set;
		}

		[XmlElement("principal_type")]
		public string PrincipalType
		{
			get;
			set;
		}
	}
}
