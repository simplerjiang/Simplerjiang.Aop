using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZmAuthParams : AopObject
	{
		[XmlElement("buckle_app_id")]
		public string BuckleAppId
		{
			get;
			set;
		}

		[XmlElement("buckle_merchant_id")]
		public string BuckleMerchantId
		{
			get;
			set;
		}
	}
}
