using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsAutoAutoinsprodPolicyApplyModel : AopObject
	{
		[XmlElement("deliver_info")]
		public DeliverInfo DeliverInfo
		{
			get;
			set;
		}

		[XmlElement("enquiry_biz_id")]
		public string EnquiryBizId
		{
			get;
			set;
		}

		[XmlElement("income_account_no")]
		public string IncomeAccountNo
		{
			get;
			set;
		}

		[XmlElement("quote_biz_id")]
		public string QuoteBizId
		{
			get;
			set;
		}

		[XmlElement("who_payed")]
		public string WhoPayed
		{
			get;
			set;
		}
	}
}
