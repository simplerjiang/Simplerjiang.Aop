using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditSceneprodPaymentApplyModel : AopObject
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("biz_product_code")]
		public string BizProductCode
		{
			get;
			set;
		}

		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("id_card")]
		public string IdCard
		{
			get;
			set;
		}

		[XmlElement("login_account")]
		public string LoginAccount
		{
			get;
			set;
		}

		[XmlElement("mybk_order_no")]
		public string MybkOrderNo
		{
			get;
			set;
		}

		[XmlElement("out_order_no")]
		public string OutOrderNo
		{
			get;
			set;
		}

		[XmlElement("out_param")]
		public string OutParam
		{
			get;
			set;
		}

		[XmlElement("out_seq_no")]
		public string OutSeqNo
		{
			get;
			set;
		}

		[XmlArray("payee_account_list")]
		[XmlArrayItem("scene_prod_payment_account_info")]
		public List<SceneProdPaymentAccountInfo> PayeeAccountList
		{
			get;
			set;
		}

		[XmlArray("payer_account_list")]
		[XmlArrayItem("scene_prod_payment_account_info")]
		public List<SceneProdPaymentAccountInfo> PayerAccountList
		{
			get;
			set;
		}

		[XmlElement("payment_product_code")]
		public string PaymentProductCode
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
