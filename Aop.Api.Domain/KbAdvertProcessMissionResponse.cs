using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertProcessMissionResponse : AopObject
	{
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

		[XmlElement("promote_status")]
		public string PromoteStatus
		{
			get;
			set;
		}
	}
}
