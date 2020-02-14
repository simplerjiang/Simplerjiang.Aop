using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayFundTransCollectSinglemoneytokenCreateModel : AopObject
	{
		[XmlElement("biz_context")]
		public string BizContext
		{
			get;
			set;
		}

		[XmlElement("collect_mode")]
		public string CollectMode
		{
			get;
			set;
		}

		[XmlElement("expire_date")]
		public string ExpireDate
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

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("out_channel")]
		public string OutChannel
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

		[XmlElement("pay_memo")]
		public string PayMemo
		{
			get;
			set;
		}

		[XmlElement("pay_mode")]
		public string PayMode
		{
			get;
			set;
		}

		[XmlElement("payee_user_id")]
		public string PayeeUserId
		{
			get;
			set;
		}
	}
}
