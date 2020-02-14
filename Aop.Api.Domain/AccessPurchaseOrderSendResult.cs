using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AccessPurchaseOrderSendResult : AopObject
	{
		[XmlElement("asset_item_id")]
		public string AssetItemId
		{
			get;
			set;
		}

		[XmlElement("asset_order_id")]
		public string AssetOrderId
		{
			get;
			set;
		}

		[XmlElement("asset_purchase_id")]
		public string AssetPurchaseId
		{
			get;
			set;
		}

		[XmlElement("error_code")]
		public string ErrorCode
		{
			get;
			set;
		}

		[XmlElement("error_desc")]
		public string ErrorDesc
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

		[XmlElement("success")]
		public bool Success
		{
			get;
			set;
		}
	}
}
