using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayPcreditLoanCollateralCarQueryModel : AopObject
	{
		[XmlElement("apply_no")]
		public string ApplyNo
		{
			get;
			set;
		}
	}
}
