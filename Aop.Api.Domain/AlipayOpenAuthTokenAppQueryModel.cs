using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenAuthTokenAppQueryModel : AopObject
	{
		[XmlElement("app_auth_token")]
		public string AppAuthToken
		{
			get;
			set;
		}
	}
}
