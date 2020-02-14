using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicAdvertDeleteModel : AopObject
	{
		[XmlElement("advert_id")]
		public string AdvertId
		{
			get;
			set;
		}
	}
}
