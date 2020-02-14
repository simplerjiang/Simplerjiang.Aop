using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsDataAutodamageEstimateQueryModel : AopObject
	{
		[XmlElement("estimate_no")]
		public string EstimateNo
		{
			get;
			set;
		}
	}
}
