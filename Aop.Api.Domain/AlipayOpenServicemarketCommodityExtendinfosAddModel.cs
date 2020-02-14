using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenServicemarketCommodityExtendinfosAddModel : AopObject
	{
		[XmlArray("commodity_ext_infos")]
		[XmlArrayItem("commodity_public_ext_infos")]
		public List<CommodityPublicExtInfos> CommodityExtInfos
		{
			get;
			set;
		}

		[XmlElement("commodity_id")]
		public string CommodityId
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
