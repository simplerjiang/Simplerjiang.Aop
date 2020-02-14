using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailWmsInboundworkCreateModel : AopObject
	{
		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("notice_order_id")]
		public string NoticeOrderId
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

		[XmlArray("work_details")]
		[XmlArrayItem("work_detail")]
		public List<WorkDetail> WorkDetails
		{
			get;
			set;
		}
	}
}
