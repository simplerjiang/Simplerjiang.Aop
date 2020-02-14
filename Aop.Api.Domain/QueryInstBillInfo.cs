using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class QueryInstBillInfo : AopObject
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("balance")]
		public string Balance
		{
			get;
			set;
		}

		[XmlElement("bill_date")]
		public string BillDate
		{
			get;
			set;
		}

		[XmlArray("bill_detail")]
		[XmlArrayItem("query_inst_bill_detail")]
		public List<QueryInstBillDetail> BillDetail
		{
			get;
			set;
		}

		[XmlElement("bill_fines")]
		public string BillFines
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

		[XmlElement("bill_user_name")]
		public string BillUserName
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

		[XmlElement("charge_uniq_id")]
		public string ChargeUniqId
		{
			get;
			set;
		}

		[XmlElement("chargeoff_inst")]
		public string ChargeoffInst
		{
			get;
			set;
		}

		[XmlElement("company_id")]
		public string CompanyId
		{
			get;
			set;
		}

		[XmlElement("extend")]
		public string Extend
		{
			get;
			set;
		}

		[XmlElement("order_type")]
		public string OrderType
		{
			get;
			set;
		}

		[XmlElement("out_id")]
		public string OutId
		{
			get;
			set;
		}

		[XmlElement("return_message")]
		public string ReturnMessage
		{
			get;
			set;
		}

		[XmlElement("sub_order_type")]
		public string SubOrderType
		{
			get;
			set;
		}
	}
}
