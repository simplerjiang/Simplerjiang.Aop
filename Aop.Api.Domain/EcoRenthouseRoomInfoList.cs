using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class EcoRenthouseRoomInfoList : AopObject
	{
		[XmlElement("deposit_end_time")]
		public string DepositEndTime
		{
			get;
			set;
		}

		[XmlElement("ka_room_id")]
		public string KaRoomId
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

		[XmlElement("room_num")]
		public string RoomNum
		{
			get;
			set;
		}
	}
}
