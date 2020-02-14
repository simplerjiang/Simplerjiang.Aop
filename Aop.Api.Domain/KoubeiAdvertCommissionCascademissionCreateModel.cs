using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiAdvertCommissionCascademissionCreateModel : AopObject
	{
		[XmlArray("cascade_mission_conf")]
		[XmlArrayItem("cascade_mission_conf_model")]
		public List<CascadeMissionConfModel> CascadeMissionConf
		{
			get;
			set;
		}

		[XmlElement("identify")]
		public string Identify
		{
			get;
			set;
		}

		[XmlElement("identify_type")]
		public string IdentifyType
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}
	}
}
