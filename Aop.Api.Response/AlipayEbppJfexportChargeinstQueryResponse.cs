using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppJfexportChargeinstQueryResponse : AopResponse
	{
		[XmlArray("charge_insts")]
		[XmlArrayItem("jf_export_charge_inst_model")]
		public List<JfExportChargeInstModel> ChargeInsts
		{
			get;
			set;
		}

		[XmlElement("total_count")]
		public long TotalCount
		{
			get;
			set;
		}
	}
}
