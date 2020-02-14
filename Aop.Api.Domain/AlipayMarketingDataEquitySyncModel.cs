using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingDataEquitySyncModel : AopObject
	{
		[XmlElement("biz_time")]
		public string BizTime
		{
			get;
			set;
		}

		[XmlElement("equity_code")]
		public string EquityCode
		{
			get;
			set;
		}

		[XmlElement("equity_from")]
		public string EquityFrom
		{
			get;
			set;
		}

		[XmlElement("equity_id")]
		public string EquityId
		{
			get;
			set;
		}

		[XmlElement("equity_info")]
		public EquityInfo EquityInfo
		{
			get;
			set;
		}

		[XmlElement("original_biz_no")]
		public string OriginalBizNo
		{
			get;
			set;
		}

		[XmlElement("original_biz_type")]
		public string OriginalBizType
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

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
