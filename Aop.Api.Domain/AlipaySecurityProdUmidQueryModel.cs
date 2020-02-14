using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityProdUmidQueryModel : AopObject
	{
		[XmlElement("token_id")]
		public string TokenId
		{
			get;
			set;
		}
	}
}
