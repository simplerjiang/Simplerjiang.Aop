using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailWmsOutboundworkModifyModel : AopObject
	{
		[XmlElement("ext_info")]
		public string ExtInfo
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

		[XmlElement("outbound_work_id")]
		public string OutboundWorkId
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
