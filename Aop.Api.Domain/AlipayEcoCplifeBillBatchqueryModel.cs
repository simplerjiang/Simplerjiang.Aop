using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoCplifeBillBatchqueryModel : AopObject
	{
		[XmlElement("acct_period")]
		public string AcctPeriod
		{
			get;
			set;
		}

		[XmlElement("batch_id")]
		public string BatchId
		{
			get;
			set;
		}

		[XmlElement("bill_status")]
		public string BillStatus
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

		[XmlElement("cost_type")]
		public string CostType
		{
			get;
			set;
		}

		[XmlElement("out_room_id")]
		public string OutRoomId
		{
			get;
			set;
		}

		[XmlElement("page_num")]
		public long PageNum
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public long PageSize
		{
			get;
			set;
		}

		[XmlElement("release_day")]
		public string ReleaseDay
		{
			get;
			set;
		}
	}
}
