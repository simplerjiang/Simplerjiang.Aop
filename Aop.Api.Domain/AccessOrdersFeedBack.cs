using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AccessOrdersFeedBack : AopObject
	{
		[XmlElement("error_code")]
		public string ErrorCode
		{
			get;
			set;
		}

		[XmlElement("error_desc")]
		public string ErrorDesc
		{
			get;
			set;
		}

		[XmlElement("feedback_id")]
		public string FeedbackId
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

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("success")]
		public bool Success
		{
			get;
			set;
		}
	}
}
