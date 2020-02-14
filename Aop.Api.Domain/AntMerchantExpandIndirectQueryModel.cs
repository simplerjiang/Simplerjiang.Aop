using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AntMerchantExpandIndirectQueryModel : AopObject
	{
		[XmlElement("external_id")]
		public string ExternalId
		{
			get;
			set;
		}

		[XmlElement("org_pid")]
		public string OrgPid
		{
			get;
			set;
		}

		[XmlElement("sub_merchant_id")]
		public string SubMerchantId
		{
			get;
			set;
		}
	}
}
