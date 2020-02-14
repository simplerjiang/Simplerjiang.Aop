using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AccessReturnQrcodeResult : AopObject
	{
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

		[XmlElement("qrcode")]
		public string Qrcode
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
