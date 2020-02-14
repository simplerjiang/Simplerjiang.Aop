using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoCplifeRoominfoUploadModel : AopObject
	{
		[XmlElement("batch_id")]
		public string BatchId
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

		[XmlArray("room_info_set")]
		[XmlArrayItem("cplife_room_info")]
		public List<CplifeRoomInfo> RoomInfoSet
		{
			get;
			set;
		}
	}
}
