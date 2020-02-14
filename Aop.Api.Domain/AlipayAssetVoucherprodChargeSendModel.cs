using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayAssetVoucherprodChargeSendModel : AopObject
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("asset_amount")]
		public string AssetAmount
		{
			get;
			set;
		}

		[XmlArray("asset_details")]
		[XmlArrayItem("vcp_asset_detail")]
		public List<VcpAssetDetail> AssetDetails
		{
			get;
			set;
		}

		[XmlElement("asset_id")]
		public string AssetId
		{
			get;
			set;
		}

		[XmlElement("asset_id_type")]
		public string AssetIdType
		{
			get;
			set;
		}

		[XmlElement("asset_type")]
		public string AssetType
		{
			get;
			set;
		}

		[XmlElement("biz_dt")]
		public string BizDt
		{
			get;
			set;
		}

		[XmlElement("extend_info")]
		public string ExtendInfo
		{
			get;
			set;
		}

		[XmlElement("fund_scence")]
		public string FundScence
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("publisher_user_id")]
		public string PublisherUserId
		{
			get;
			set;
		}
	}
}
