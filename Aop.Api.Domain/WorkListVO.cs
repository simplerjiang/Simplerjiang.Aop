using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class WorkListVO : AopObject
	{
		[XmlElement("gmt_finished")]
		public string GmtFinished
		{
			get;
			set;
		}

		[XmlElement("notice_out_biz_no")]
		public string NoticeOutBizNo
		{
			get;
			set;
		}

		[XmlElement("notice_out_biz_type")]
		public string NoticeOutBizType
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

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("warehouse_code")]
		public string WarehouseCode
		{
			get;
			set;
		}

		[XmlElement("work_id")]
		public string WorkId
		{
			get;
			set;
		}

		[XmlElement("work_type")]
		public string WorkType
		{
			get;
			set;
		}
	}
}
