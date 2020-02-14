using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppConfigChargeinstSearchResponse : AopResponse
	{
		[XmlArray("charge_inst_mode_result")]
		[XmlArrayItem("charge_inst_mode")]
		public List<ChargeInstMode> ChargeInstModeResult
		{
			get;
			set;
		}
	}
}
