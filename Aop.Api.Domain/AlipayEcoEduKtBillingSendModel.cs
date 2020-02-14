using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoEduKtBillingSendModel : AopObject
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("charge_bill_title")]
		public string ChargeBillTitle
		{
			get;
			set;
		}

		[XmlArray("charge_item")]
		[XmlArrayItem("charge_items")]
		public List<ChargeItems> ChargeItem
		{
			get;
			set;
		}

		[XmlElement("charge_type")]
		public string ChargeType
		{
			get;
			set;
		}

		[XmlElement("child_name")]
		public string ChildName
		{
			get;
			set;
		}

		[XmlElement("class_in")]
		public string ClassIn
		{
			get;
			set;
		}

		[XmlElement("end_enable")]
		public string EndEnable
		{
			get;
			set;
		}

		[XmlElement("gmt_end")]
		public string GmtEnd
		{
			get;
			set;
		}

		[XmlElement("grade")]
		public string Grade
		{
			get;
			set;
		}

		[XmlElement("out_trade_no")]
		public string OutTradeNo
		{
			get;
			set;
		}

		[XmlElement("partner_id")]
		public string PartnerId
		{
			get;
			set;
		}

		[XmlElement("school_no")]
		public string SchoolNo
		{
			get;
			set;
		}

		[XmlElement("school_pid")]
		public string SchoolPid
		{
			get;
			set;
		}

		[XmlElement("student_code")]
		public string StudentCode
		{
			get;
			set;
		}

		[XmlElement("student_identify")]
		public string StudentIdentify
		{
			get;
			set;
		}

		[XmlArray("users")]
		[XmlArrayItem("user_details")]
		public List<UserDetails> Users
		{
			get;
			set;
		}
	}
}
