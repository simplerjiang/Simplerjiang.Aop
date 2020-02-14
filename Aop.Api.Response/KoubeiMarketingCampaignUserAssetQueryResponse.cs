using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignUserAssetQueryResponse : AopResponse
	{
		[XmlArray("voucher_asset_list")]
		[XmlArrayItem("voucher_detail_info")]
		public List<VoucherDetailInfo> VoucherAssetList
		{
			get;
			set;
		}

		[XmlElement("voucher_asset_num")]
		public long VoucherAssetNum
		{
			get;
			set;
		}
	}
}
