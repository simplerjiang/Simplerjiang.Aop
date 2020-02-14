using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserAddressQueryModel : AopObject
	{
		[XmlElement("address_id")]
		public string AddressId
		{
			get;
			set;
		}
	}
}
