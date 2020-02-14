using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ArrangementInvolvedPartyQuerier : AopObject
	{
		[XmlElement("ip_id")]
		public string IpId
		{
			get;
			set;
		}

		[XmlElement("ip_role_id")]
		public string IpRoleId
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
	}
}
