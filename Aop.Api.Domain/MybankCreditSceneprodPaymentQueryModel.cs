using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditSceneprodPaymentQueryModel : AopObject
	{
		[XmlElement("in_apply_no")]
		public string InApplyNo
		{
			get;
			set;
		}
	}
}
