using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoCplifeRoominfoUploadResponse : AopResponse
	{
		[XmlElement("community_id")]
		public string CommunityId
		{
			get;
			set;
		}

		[XmlArray("room_info_set")]
		[XmlArrayItem("cplife_room_info_resp")]
		public List<CplifeRoomInfoResp> RoomInfoSet
		{
			get;
			set;
		}
	}
}
