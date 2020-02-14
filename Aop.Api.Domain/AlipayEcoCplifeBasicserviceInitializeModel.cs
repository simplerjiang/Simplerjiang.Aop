using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoCplifeBasicserviceInitializeModel : AopObject
	{
		[XmlElement("account")]
		public string Account
		{
			get;
			set;
		}

		[XmlElement("account_type")]
		public string AccountType
		{
			get;
			set;
		}

		[XmlElement("community_id")]
		public string CommunityId
		{
			get;
			set;
		}

		[XmlElement("external_invoke_address")]
		public string ExternalInvokeAddress
		{
			get;
			set;
		}

		[XmlElement("service_expires")]
		public string ServiceExpires
		{
			get;
			set;
		}

		[XmlElement("service_type")]
		public string ServiceType
		{
			get;
			set;
		}
	}
}
