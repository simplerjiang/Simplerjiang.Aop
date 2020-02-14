using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CplifeRoomDetail : AopObject
	{
		[XmlElement("address")]
		public string Address
		{
			get;
			set;
		}

		[XmlElement("building")]
		public string Building
		{
			get;
			set;
		}

		[XmlElement("group")]
		public string Group
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

		[XmlElement("room")]
		public string Room
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

		[XmlElement("unit")]
		public string Unit
		{
			get;
			set;
		}
	}
}
