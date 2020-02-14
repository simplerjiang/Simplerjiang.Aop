using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMerchantOperatorRolerelationBindModel : AopObject
	{
		[XmlElement("auth_code")]
		public string AuthCode
		{
			get;
			set;
		}

		[XmlArray("operator_ids")]
		[XmlArrayItem("string")]
		public List<string> OperatorIds
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
