using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CplifeRoomInfoResp : AopObject
	{
		[XmlElement("out_room_id")]
		public string OutRoomId
		{
			get;
			set;
		}

		[XmlElement("room_id")]
		public string RoomId
		{
			get;
			set;
		}
	}
}
