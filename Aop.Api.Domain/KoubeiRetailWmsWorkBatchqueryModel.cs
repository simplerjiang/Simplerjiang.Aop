using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailWmsWorkBatchqueryModel : AopObject
	{
		[XmlElement("gmt_finished_from")]
		public string GmtFinishedFrom
		{
			get;
			set;
		}

		[XmlElement("gmt_finished_to")]
		public string GmtFinishedTo
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

		[XmlElement("operate_context")]
		public OperateContext OperateContext
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

		[XmlElement("page_no")]
		public long PageNo
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public long PageSize
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

		[XmlElement("work_type")]
		public string WorkType
		{
			get;
			set;
		}
	}
}
