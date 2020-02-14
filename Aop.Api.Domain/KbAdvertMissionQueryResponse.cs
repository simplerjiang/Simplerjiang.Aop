using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertMissionQueryResponse : AopObject
	{
		[XmlElement("gmt_end")]
		public string GmtEnd
		{
			get;
			set;
		}

		[XmlElement("gmt_start")]
		public string GmtStart
		{
			get;
			set;
		}

		[XmlElement("mission_id")]
		public string MissionId
		{
			get;
			set;
		}

		[XmlElement("promote_status")]
		public string PromoteStatus
		{
			get;
			set;
		}

		[XmlArray("subjects")]
		[XmlArrayItem("kb_advert_mission_subject")]
		public List<KbAdvertMissionSubject> Subjects
		{
			get;
			set;
		}
	}
}
