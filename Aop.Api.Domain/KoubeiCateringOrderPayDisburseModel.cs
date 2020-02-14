using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringOrderPayDisburseModel : AopObject
	{
		[XmlElement("auth_code")]
		public string AuthCode
		{
			get;
			set;
		}

		[XmlElement("member_flag")]
		public bool MemberFlag
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

		[XmlElement("pos_order_key")]
		public PosOrderKey PosOrderKey
		{
			get;
			set;
		}

		[XmlElement("timeout")]
		public string Timeout
		{
			get;
			set;
		}

		[XmlElement("total_amount")]
		public string TotalAmount
		{
			get;
			set;
		}

		[XmlElement("undiscountable")]
		public bool Undiscountable
		{
			get;
			set;
		}
	}
}
