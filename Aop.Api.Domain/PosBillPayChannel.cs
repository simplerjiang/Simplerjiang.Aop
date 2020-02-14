using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PosBillPayChannel : AopObject
	{
		[XmlElement("channel_type")]
		public string ChannelType
		{
			get;
			set;
		}

		[XmlArray("discount_details")]
		[XmlArrayItem("pos_discount_detail")]
		public List<PosDiscountDetail> DiscountDetails
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("operator")]
		public string Operator
		{
			get;
			set;
		}

		[XmlElement("out_pay_no")]
		public string OutPayNo
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

		[XmlElement("pay_no")]
		public string PayNo
		{
			get;
			set;
		}

		[XmlElement("pay_time")]
		public string PayTime
		{
			get;
			set;
		}

		[XmlElement("receipt_amount")]
		public string ReceiptAmount
		{
			get;
			set;
		}

		[XmlElement("user_identity")]
		public string UserIdentity
		{
			get;
			set;
		}
	}
}
