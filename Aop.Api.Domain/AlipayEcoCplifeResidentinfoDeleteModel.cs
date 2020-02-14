using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoCplifeResidentinfoDeleteModel : AopObject
	{
		[XmlElement("community_id")]
		public string CommunityId
		{
			get;
			set;
		}

		[XmlArray("out_resident_id_set")]
		[XmlArrayItem("string")]
		public List<string> OutResidentIdSet
		{
			get;
			set;
		}
	}
}
