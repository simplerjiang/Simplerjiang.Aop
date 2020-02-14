using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOfflinePayMasterKey : AopObject
	{
		[XmlElement("key_id")]
		public long KeyId
		{
			get;
			set;
		}

		[XmlElement("public_key")]
		public string PublicKey
		{
			get;
			set;
		}
	}
}
