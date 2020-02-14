using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayAssetCardReturnRefundModel : AopObject
	{
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

		[XmlElement("biz_dt")]
		public string BizDt
		{
			get;
			set;
		}

		[XmlElement("biz_from")]
		public string BizFrom
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

		[XmlElement("is_cancel")]
		public string IsCancel
		{
			get;
			set;
		}

		[XmlElement("operator")]
		public string Operator
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

		[XmlArray("recharge_details")]
		[XmlArrayItem("recharge_detail")]
		public List<RechargeDetail> RechargeDetails
		{
			get;
			set;
		}

		[XmlElement("return_amount")]
		public string ReturnAmount
		{
			get;
			set;
		}

		[XmlElement("return_asset_amount")]
		public string ReturnAssetAmount
		{
			get;
			set;
		}

		[XmlElement("return_fee_amount")]
		public string ReturnFeeAmount
		{
			get;
			set;
		}

		[XmlElement("return_fee_asset_amount")]
		public string ReturnFeeAssetAmount
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
