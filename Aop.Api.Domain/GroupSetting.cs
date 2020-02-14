using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class GroupSetting : AopObject
	{
		[XmlElement("group_name")]
		public string GroupName
		{
			get;
			set;
		}

		[XmlElement("is_openinv")]
		public bool IsOpeninv
		{
			get;
			set;
		}

		[XmlElement("public_notice")]
		public string PublicNotice
		{
			get;
			set;
		}
	}
}
