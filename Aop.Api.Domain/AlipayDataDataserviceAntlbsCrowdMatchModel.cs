using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayDataDataserviceAntlbsCrowdMatchModel : AopObject
	{
		[XmlArray("crowd_code")]
		[XmlArrayItem("string")]
		public List<string> CrowdCode
		{
			get;
			set;
		}

		[XmlElement("scene_code")]
		public string SceneCode
		{
			get;
			set;
		}

		[XmlElement("uid")]
		public string Uid
		{
			get;
			set;
		}

		[XmlElement("uid_type")]
		public string UidType
		{
			get;
			set;
		}
	}
}
