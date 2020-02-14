using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceIotAccountbindingCreateModel : AopObject
	{
		[XmlElement("protocol_supplier_id")]
		public string ProtocolSupplierId
		{
			get;
			set;
		}

		[XmlElement("protocol_user_id")]
		public string ProtocolUserId
		{
			get;
			set;
		}

		[XmlElement("protocol_user_name")]
		public string ProtocolUserName
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
