using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayTradeBatchRefundModel : AopObject
	{
		[XmlElement("batch_no")]
		public string BatchNo
		{
			get;
			set;
		}

		[XmlElement("batch_num")]
		public string BatchNum
		{
			get;
			set;
		}

		[XmlArray("detail_data")]
		[XmlArrayItem("refund_detail")]
		public List<RefundDetail> DetailData
		{
			get;
			set;
		}

		[XmlElement("refund_date")]
		public string RefundDate
		{
			get;
			set;
		}

		[XmlElement("use_freeze_amount")]
		public string UseFreezeAmount
		{
			get;
			set;
		}
	}
}
