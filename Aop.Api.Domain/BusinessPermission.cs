using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class BusinessPermission : AopObject
	{
		[XmlElement("domain")]
		public string Domain
		{
			get;
			set;
		}

		[XmlElement("permission_code")]
		public string PermissionCode
		{
			get;
			set;
		}

		[XmlElement("source_permission_code")]
		public string SourcePermissionCode
		{
			get;
			set;
		}
	}
}
