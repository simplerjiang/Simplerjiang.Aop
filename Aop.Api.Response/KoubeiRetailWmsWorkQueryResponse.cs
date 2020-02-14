using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailWmsWorkQueryResponse : AopResponse
	{
		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

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

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("remark")]
		public string Remark
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

		[XmlArray("work_details")]
		[XmlArrayItem("work_detail")]
		public List<WorkDetail> WorkDetails
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
	}
}
