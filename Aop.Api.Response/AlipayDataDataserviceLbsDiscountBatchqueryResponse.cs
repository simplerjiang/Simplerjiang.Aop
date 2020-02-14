using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDataDataserviceLbsDiscountBatchqueryResponse : AopResponse
	{
		[XmlArray("discounts")]
		[XmlArrayItem("antlbs_k_b_discount_info")]
		public List<AntlbsKBDiscountInfo> Discounts
		{
			get;
			set;
		}
	}
}
