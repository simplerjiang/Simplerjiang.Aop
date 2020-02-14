using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AccessPurchaseOrderSend : AopObject
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

		[XmlElement("express_code")]
		public string ExpressCode
		{
			get;
			set;
		}

		[XmlElement("express_name")]
		public string ExpressName
		{
			get;
			set;
		}

		[XmlElement("express_no")]
		public string ExpressNo
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

		[XmlElement("po_no")]
		public string PoNo
		{
			get;
			set;
		}

		[XmlElement("return_qrcode_count")]
		public string ReturnQrcodeCount
		{
			get;
			set;
		}

		[XmlElement("ship_count")]
		public string ShipCount
		{
			get;
			set;
		}
	}
}
