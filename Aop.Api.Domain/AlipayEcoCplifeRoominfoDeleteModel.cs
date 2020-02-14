using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoCplifeRoominfoDeleteModel : AopObject
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

		[XmlArray("out_room_id_set")]
		[XmlArrayItem("string")]
		public List<string> OutRoomIdSet
		{
			get;
			set;
		}
	}
}
