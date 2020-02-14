using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppFacepayBillPayModel : AopObject
	{
		[XmlElement("bill_date")]
		public string BillDate
		{
			get;
			set;
		}

		[XmlElement("bill_key")]
		public string BillKey
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

		[XmlElement("charge_inst")]
		public string ChargeInst
		{
			get;
			set;
		}

		[XmlElement("extend_field")]
		public string ExtendField
		{
			get;
			set;
		}

		[XmlElement("fine_amount")]
		public string FineAmount
		{
			get;
			set;
		}

		[XmlElement("inst_no")]
		public string InstNo
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

		[XmlElement("pay_amount")]
		public string PayAmount
		{
			get;
			set;
		}

		[XmlElement("pid")]
		public string Pid
		{
			get;
			set;
		}

		[XmlElement("sub_biz_type")]
		public string SubBizType
		{
			get;
			set;
		}

		[XmlElement("user_identity_code")]
		public string UserIdentityCode
		{
			get;
			set;
		}
	}
}
