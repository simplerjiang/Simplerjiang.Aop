using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoCplifeRoominfoQueryResponse : AopResponse
	{
		[XmlArray("room_info")]
		[XmlArrayItem("cplife_room_detail")]
		public List<CplifeRoomDetail> RoomInfo
		{
			get;
			set;
		}

		[XmlElement("total_room_number")]
		public long TotalRoomNumber
		{
			get;
			set;
		}
	}
}
