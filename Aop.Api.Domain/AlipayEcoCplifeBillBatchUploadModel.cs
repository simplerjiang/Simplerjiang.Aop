using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoCplifeBillBatchUploadModel : AopObject
	{
		[XmlElement("batch_id")]
		public string BatchId
		{
			get;
			set;
		}

		[XmlArray("bill_set")]
		[XmlArrayItem("c_p_bill_set")]
		public List<CPBillSet> BillSet
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
