using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayFundTransToaccountTransferModel : AopObject
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("ext_param")]
		public string ExtParam
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

		[XmlElement("payee_account")]
		public string PayeeAccount
		{
			get;
			set;
		}

		[XmlElement("payee_real_name")]
		public string PayeeRealName
		{
			get;
			set;
		}

		[XmlElement("payee_type")]
		public string PayeeType
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

		[XmlElement("payer_show_name")]
		public string PayerShowName
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
	}
}
