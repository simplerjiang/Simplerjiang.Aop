using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoRenthouseBillOrderSyncResponse : AopResponse
	{
		[XmlArray("result_bill_list")]
		[XmlArrayItem("string")]
		public List<string> ResultBillList
		{
			get;
			set;
		}
	}
}
