using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingToolIsvMerchantQueryResponse : AopResponse
	{
		[XmlArray("merchant_infos")]
		[XmlArrayItem("isv_merchant_info")]
		public List<IsvMerchantInfo> MerchantInfos
		{
			get;
			set;
		}

		[XmlElement("shop_count")]
		public string ShopCount
		{
			get;
			set;
		}

		[XmlArray("shop_summary_infos")]
		[XmlArrayItem("shop_summary_info")]
		public List<ShopSummaryInfo> ShopSummaryInfos
		{
			get;
			set;
		}
	}
}
