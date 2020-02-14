using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PointAccountLog : AopObject
	{
		[XmlElement("account_log_id")]
		public string AccountLogId
		{
			get;
			set;
		}

		[XmlElement("balance")]
		public long Balance
		{
			get;
			set;
		}

		[XmlElement("order_no")]
		public string OrderNo
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

		[XmlElement("point_amount")]
		public long PointAmount
		{
			get;
			set;
		}

		[XmlElement("sub_trans_code")]
		public string SubTransCode
		{
			get;
			set;
		}

		[XmlElement("sub_trans_code_cn")]
		public string SubTransCodeCn
		{
			get;
			set;
		}

		[XmlElement("trans_code")]
		public string TransCode
		{
			get;
			set;
		}

		[XmlElement("trans_date")]
		public string TransDate
		{
			get;
			set;
		}

		[XmlElement("trans_memo")]
		public string TransMemo
		{
			get;
			set;
		}
	}
}
