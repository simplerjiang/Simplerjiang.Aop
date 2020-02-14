using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoRenthouseRoomStateSyncModel : AopObject
	{
		[XmlElement("flats_tag")]
		public long FlatsTag
		{
			get;
			set;
		}

		[XmlElement("rent_status")]
		public long RentStatus
		{
			get;
			set;
		}

		[XmlElement("room_code")]
		public string RoomCode
		{
			get;
			set;
		}

		[XmlElement("room_status")]
		public long RoomStatus
		{
			get;
			set;
		}
	}
}
