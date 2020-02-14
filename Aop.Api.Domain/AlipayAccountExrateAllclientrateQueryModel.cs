using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayAccountExrateAllclientrateQueryModel : AopObject
	{
		[XmlElement("client_id")]
		public string ClientId
		{
			get;
			set;
		}

		[XmlElement("profile_id")]
		public string ProfileId
		{
			get;
			set;
		}
	}
}
