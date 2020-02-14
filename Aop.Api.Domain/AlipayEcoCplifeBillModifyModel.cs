using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoCplifeBillModifyModel : AopObject
	{
		[XmlArray("bill_entry_list")]
		[XmlArrayItem("c_p_bill_modify_set")]
		public List<CPBillModifySet> BillEntryList
		{
			get;
			set;
		}

		[XmlElement("community_id")]
		public string CommunityId
		{
			get;
			set;
		}
	}
}
