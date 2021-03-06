using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CPBillResultSet : AopObject
	{
		[XmlElement("acct_period")]
		public string AcctPeriod
		{
			get;
			set;
		}

		[XmlElement("bill_entry_amount")]
		public string BillEntryAmount
		{
			get;
			set;
		}

		[XmlElement("bill_entry_id")]
		public string BillEntryId
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

		[XmlElement("deadline")]
		public string Deadline
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

		[XmlElement("release_day")]
		public string ReleaseDay
		{
			get;
			set;
		}

		[XmlElement("room_address")]
		public string RoomAddress
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
