using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFundBatchDetailQueryResponse : AopResponse
	{
		[XmlArray("acc_detail_list")]
		[XmlArrayItem("acc_detail_model")]
		public List<AccDetailModel> AccDetailList
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

		[XmlElement("batch_status")]
		public string BatchStatus
		{
			get;
			set;
		}

		[XmlElement("batch_trans_id")]
		public string BatchTransId
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

		[XmlElement("error_code")]
		public string ErrorCode
		{
			get;
			set;
		}

		[XmlElement("fail_reason")]
		public string FailReason
		{
			get;
			set;
		}

		[XmlElement("page_num")]
		public long PageNum
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

		[XmlElement("payment_amount")]
		public string PaymentAmount
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

		[XmlElement("sign_principal")]
		public string SignPrincipal
		{
			get;
			set;
		}

		[XmlElement("total_item_count")]
		public long TotalItemCount
		{
			get;
			set;
		}

		[XmlElement("total_page_count")]
		public long TotalPageCount
		{
			get;
			set;
		}
	}
}
