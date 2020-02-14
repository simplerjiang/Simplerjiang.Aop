using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenServicemarketCommodityExtendinfosConfirmModel : AopObject
	{
		[XmlArray("commodity_ext_infos")]
		[XmlArrayItem("commodity_ext_info_confirm")]
		public List<CommodityExtInfoConfirm> CommodityExtInfos
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

		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
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
