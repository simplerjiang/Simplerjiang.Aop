using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoCplifeResidentinfoUploadModel : AopObject
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

		[XmlArray("resident_info")]
		[XmlArrayItem("cplife_resident_info")]
		public List<CplifeResidentInfo> ResidentInfo
		{
			get;
			set;
		}
	}
}
