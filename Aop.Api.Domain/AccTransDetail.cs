using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AccTransDetail : AopObject
	{
		[XmlElement("alipay_order_no")]
		public string AlipayOrderNo
		{
			get;
			set;
		}

		[XmlElement("cert_info")]
		public CertInfo CertInfo
		{
			get;
			set;
		}

		[XmlElement("detail_no")]
		public string DetailNo
		{
			get;
			set;
		}

		[XmlElement("ori_txn_info")]
		public OriTxnInfo OriTxnInfo
		{
			get;
			set;
		}

		[XmlElement("payee_info")]
		public AccPayeeInfo PayeeInfo
		{
			get;
			set;
		}

		[XmlElement("reach_time")]
		public string ReachTime
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

		[XmlElement("settlement_currency")]
		public string SettlementCurrency
		{
			get;
			set;
		}

		[XmlElement("trans_amount")]
		public string TransAmount
		{
			get;
			set;
		}

		[XmlElement("trans_currency")]
		public string TransCurrency
		{
			get;
			set;
		}
	}
}
