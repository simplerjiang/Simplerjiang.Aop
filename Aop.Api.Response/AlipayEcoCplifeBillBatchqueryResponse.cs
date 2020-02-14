using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoCplifeBillBatchqueryResponse : AopResponse
	{
		[XmlArray("bill_result_set")]
		[XmlArrayItem("c_p_bill_result_set")]
		public List<CPBillResultSet> BillResultSet
		{
			get;
			set;
		}

		[XmlElement("current_page_num")]
		public long CurrentPageNum
		{
			get;
			set;
		}

		[XmlElement("total_bill_count")]
		public long TotalBillCount
		{
			get;
			set;
		}
	}
}
