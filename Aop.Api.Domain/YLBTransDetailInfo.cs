using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class YLBTransDetailInfo : AopObject
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlElement("trans_account_date")]
		public string TransAccountDate
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

		[XmlElement("trans_name")]
		public string TransName
		{
			get;
			set;
		}

		[XmlElement("trans_status")]
		public string TransStatus
		{
			get;
			set;
		}

		[XmlElement("trans_type")]
		public string TransType
		{
			get;
			set;
		}
	}
}
