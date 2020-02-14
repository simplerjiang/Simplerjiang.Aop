using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CustomsDeclareRecordInfo : AopObject
	{
		[XmlElement("alipay_declare_no")]
		public string AlipayDeclareNo
		{
			get;
			set;
		}

		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("customs_place")]
		public string CustomsPlace
		{
			get;
			set;
		}

		[XmlElement("customs_result_code")]
		public string CustomsResultCode
		{
			get;
			set;
		}

		[XmlElement("customs_result_info")]
		public string CustomsResultInfo
		{
			get;
			set;
		}

		[XmlElement("customs_result_return_time")]
		public string CustomsResultReturnTime
		{
			get;
			set;
		}

		[XmlElement("is_split")]
		public string IsSplit
		{
			get;
			set;
		}

		[XmlElement("last_modified_time")]
		public string LastModifiedTime
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

		[XmlElement("merchant_customs_code")]
		public string MerchantCustomsCode
		{
			get;
			set;
		}

		[XmlElement("merchant_customs_name")]
		public string MerchantCustomsName
		{
			get;
			set;
		}

		[XmlElement("out_request_no")]
		public string OutRequestNo
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

		[XmlElement("sub_out_biz_no")]
		public string SubOutBizNo
		{
			get;
			set;
		}

		[XmlElement("trade_no")]
		public string TradeNo
		{
			get;
			set;
		}
	}
}
