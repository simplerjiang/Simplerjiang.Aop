using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ReduceToAmtDstCampPrizeModel : AopObject
	{
		[XmlElement("reduct_to_amt")]
		public string ReductToAmt
		{
			get;
			set;
		}
	}
}
