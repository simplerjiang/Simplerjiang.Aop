using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class IdentityParams : AopObject
	{
		[XmlElement("cert_no")]
		public string CertNo
		{
			get;
			set;
		}

		[XmlElement("identity_hash")]
		public string IdentityHash
		{
			get;
			set;
		}

		[XmlElement("sign_user_id")]
		public string SignUserId
		{
			get;
			set;
		}

		[XmlElement("user_name")]
		public string UserName
		{
			get;
			set;
		}
	}
}
