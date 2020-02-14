using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SubMerchant : AopObject
	{
		[XmlElement("merchant_id")]
		public string MerchantId
		{
			get;
			set;
		}

		[XmlElement("merchant_type")]
		public string MerchantType
		{
			get;
			set;
		}
	}
}
