using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenServicemarketCommodityAuditConfirmModel : AopObject
	{
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
