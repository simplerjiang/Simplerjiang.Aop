using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoCplifeBillDeleteResponse : AopResponse
	{
		[XmlArray("alive_bill_entry_list")]
		[XmlArrayItem("c_p_alive_bill_entry_set")]
		public List<CPAliveBillEntrySet> AliveBillEntryList
		{
			get;
			set;
		}
	}
}
