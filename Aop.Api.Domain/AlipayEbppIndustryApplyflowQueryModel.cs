using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppIndustryApplyflowQueryModel : AopObject
	{
		[XmlElement("apply_flow_no")]
		public string ApplyFlowNo
		{
			get;
			set;
		}

		[XmlElement("extend_field")]
		public string ExtendField
		{
			get;
			set;
		}

		[XmlElement("out_apply_no")]
		public string OutApplyNo
		{
			get;
			set;
		}
	}
}
