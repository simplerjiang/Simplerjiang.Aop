using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ProdIPRelationVO : AopObject
	{
		[XmlElement("ip_alias_name")]
		public string IpAliasName
		{
			get;
			set;
		}

		[XmlElement("ip_belong_platform")]
		public string IpBelongPlatform
		{
			get;
			set;
		}

		[XmlElement("ip_code")]
		public string IpCode
		{
			get;
			set;
		}

		[XmlElement("ip_name")]
		public string IpName
		{
			get;
			set;
		}

		[XmlElement("ip_sub_type")]
		public string IpSubType
		{
			get;
			set;
		}

		[XmlElement("ip_type")]
		public string IpType
		{
			get;
			set;
		}

		[XmlElement("prod_code")]
		public string ProdCode
		{
			get;
			set;
		}

		[XmlElement("prod_version")]
		public string ProdVersion
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
