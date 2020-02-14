using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class RefundRoyaltyResult : AopObject
	{
		[XmlElement("refund_amount")]
		public string RefundAmount
		{
			get;
			set;
		}

		[XmlElement("result_code")]
		public string ResultCode
		{
			get;
			set;
		}

		[XmlElement("trans_in")]
		public string TransIn
		{
			get;
			set;
		}

		[XmlElement("trans_in_email")]
		public string TransInEmail
		{
			get;
			set;
		}

		[XmlElement("trans_out")]
		public string TransOut
		{
			get;
			set;
		}

		[XmlElement("trans_out_email")]
		public string TransOutEmail
		{
			get;
			set;
		}
	}
}
