using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOfflineMarketShopSummaryBatchqueryModel : AopObject
	{
		[XmlElement("op_role")]
		public string OpRole
		{
			get;
			set;
		}

		[XmlElement("page_no")]
		public long PageNo
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public long PageSize
		{
			get;
			set;
		}

		[XmlElement("query_type")]
		public string QueryType
		{
			get;
			set;
		}

		[XmlElement("related_partner_id")]
		public string RelatedPartnerId
		{
			get;
			set;
		}

		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}

		[XmlElement("shop_status")]
		public string ShopStatus
		{
			get;
			set;
		}
	}
}
