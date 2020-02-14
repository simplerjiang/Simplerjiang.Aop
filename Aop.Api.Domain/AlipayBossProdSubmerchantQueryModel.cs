using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayBossProdSubmerchantQueryModel : AopObject
	{
		[XmlElement("external_id")]
		public string ExternalId
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
