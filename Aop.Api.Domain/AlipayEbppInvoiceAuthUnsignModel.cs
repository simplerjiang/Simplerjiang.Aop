using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppInvoiceAuthUnsignModel : AopObject
	{
		[XmlElement("authorization_type")]
		public string AuthorizationType
		{
			get;
			set;
		}

		[XmlElement("m_short_name")]
		public string MShortName
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
