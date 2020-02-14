using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarMaintainOrderCreateModel : AopObject
	{
		[XmlElement("biz_status")]
		public string BizStatus
		{
			get;
			set;
		}

		[XmlElement("biz_status_txt")]
		public string BizStatusTxt
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

		[XmlElement("out_order_no")]
		public string OutOrderNo
		{
			get;
			set;
		}

		[XmlElement("subject")]
		public string Subject
		{
			get;
			set;
		}

		[XmlElement("summary")]
		public string Summary
		{
			get;
			set;
		}

		[XmlElement("total_fee")]
		public string TotalFee
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
