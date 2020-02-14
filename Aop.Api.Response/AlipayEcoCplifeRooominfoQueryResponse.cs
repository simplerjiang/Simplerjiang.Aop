using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoCplifeRooominfoQueryResponse : AopResponse
	{
		[XmlArray("room_info")]
		[XmlArrayItem("cplife_room_detail")]
		public List<CplifeRoomDetail> RoomInfo
		{
			get;
			set;
		}
	}
}
