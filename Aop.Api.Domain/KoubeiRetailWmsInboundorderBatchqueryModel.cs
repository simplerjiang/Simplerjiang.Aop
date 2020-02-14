using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailWmsInboundorderBatchqueryModel : AopObject
	{
		[XmlArray("inbound_order_id_list")]
		[XmlArrayItem("string")]
		public List<string> InboundOrderIdList
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

		[XmlArray("out_biz_no_list")]
		[XmlArrayItem("string")]
		public List<string> OutBizNoList
		{
			get;
			set;
		}
	}
}
