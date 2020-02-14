using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayFundBatchTransferModel : AopObject
	{
		[XmlArray("acc_detail_list")]
		[XmlArrayItem("acc_trans_detail")]
		public List<AccTransDetail> AccDetailList
		{
			get;
			set;
		}

		[XmlElement("batch_no")]
		public string BatchNo
		{
			get;
			set;
		}

		[XmlElement("billing_address")]
		public string BillingAddress
		{
			get;
			set;
		}

		[XmlElement("biz_code")]
		public string BizCode
		{
			get;
			set;
		}

		[XmlElement("biz_scene")]
		public string BizScene
		{
			get;
			set;
		}

		[XmlElement("extend_params")]
		public string ExtendParams
		{
			get;
			set;
		}

		[XmlElement("pay_retry")]
		public string PayRetry
		{
			get;
			set;
		}

		[XmlElement("payer_account")]
		public string PayerAccount
		{
			get;
			set;
		}

		[XmlElement("payer_account_type")]
		public string PayerAccountType
		{
			get;
			set;
		}

		[XmlElement("payment_currency")]
		public string PaymentCurrency
		{
			get;
			set;
		}

		[XmlElement("product_code")]
		public string ProductCode
		{
			get;
			set;
		}

		[XmlElement("request_value_time")]
		public string RequestValueTime
		{
			get;
			set;
		}

		[XmlElement("sign_principal")]
		public string SignPrincipal
		{
			get;
			set;
		}

		[XmlElement("total_count")]
		public string TotalCount
		{
			get;
			set;
		}

		[XmlElement("total_trans_amount")]
		public string TotalTransAmount
		{
			get;
			set;
		}

		[XmlElement("total_trans_currency")]
		public string TotalTransCurrency
		{
			get;
			set;
		}
	}
}
