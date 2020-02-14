using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayFundTransTobankTransferModel : AopObject
	{
		[XmlElement("amount")]
		public string Amount
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

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("payee_account_name")]
		public string PayeeAccountName
		{
			get;
			set;
		}

		[XmlElement("payee_account_type")]
		public string PayeeAccountType
		{
			get;
			set;
		}

		[XmlElement("payee_bank_code")]
		public string PayeeBankCode
		{
			get;
			set;
		}

		[XmlElement("payee_card_no")]
		public string PayeeCardNo
		{
			get;
			set;
		}

		[XmlElement("payee_inst_branch_name")]
		public string PayeeInstBranchName
		{
			get;
			set;
		}

		[XmlElement("payee_inst_city")]
		public string PayeeInstCity
		{
			get;
			set;
		}

		[XmlElement("payee_inst_name")]
		public string PayeeInstName
		{
			get;
			set;
		}

		[XmlElement("payee_inst_province")]
		public string PayeeInstProvince
		{
			get;
			set;
		}

		[XmlElement("payer_real_name")]
		public string PayerRealName
		{
			get;
			set;
		}

		[XmlElement("remark")]
		public string Remark
		{
			get;
			set;
		}

		[XmlElement("time_liness")]
		public string TimeLiness
		{
			get;
			set;
		}
	}
}
