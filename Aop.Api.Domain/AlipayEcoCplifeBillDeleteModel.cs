using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoCplifeBillDeleteModel : AopObject
	{
		[XmlArray("bill_entry_id_list")]
		[XmlArrayItem("string")]
		public List<string> BillEntryIdList
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
