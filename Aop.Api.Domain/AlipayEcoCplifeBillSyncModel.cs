using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoCplifeBillSyncModel : AopObject
	{
		[XmlElement("bill_entry_id")]
		public string BillEntryId
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

		[XmlElement("new_deadline")]
		public string NewDeadline
		{
			get;
			set;
		}

		[XmlElement("new_entry_amount")]
		public string NewEntryAmount
		{
			get;
			set;
		}

		[XmlElement("operate_type")]
		public string OperateType
		{
			get;
			set;
		}
	}
}
