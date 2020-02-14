using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppCommonBillkeyQueryResponse : AopResponse
	{
		[XmlArray("bill_key_list")]
		[XmlArrayItem("ebpp_bill_key")]
		public List<EbppBillKey> BillKeyList
		{
			get;
			set;
		}
	}
}
