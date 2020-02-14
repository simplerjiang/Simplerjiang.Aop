using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicAdvertModifyModel : AopObject
	{
		[XmlElement("advert_id")]
		public string AdvertId
		{
			get;
			set;
		}

		[XmlArray("advert_items")]
		[XmlArrayItem("advert_item")]
		public List<AdvertItem> AdvertItems
		{
			get;
			set;
		}
	}
}
