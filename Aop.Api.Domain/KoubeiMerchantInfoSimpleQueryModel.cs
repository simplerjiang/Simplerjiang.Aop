using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMerchantInfoSimpleQueryModel : AopObject
	{
		[XmlElement("auth_code")]
		public string AuthCode
		{
			get;
			set;
		}
	}
}
