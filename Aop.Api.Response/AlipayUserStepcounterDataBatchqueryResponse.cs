using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserStepcounterDataBatchqueryResponse : AopResponse
	{
		[XmlArray("step_info")]
		[XmlArrayItem("stepcounter_data_info")]
		public List<StepcounterDataInfo> StepInfo
		{
			get;
			set;
		}
	}
}
