using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiAdvertCommissionMissionQueryModel : AopObject
	{
		[XmlArray("identify_list")]
		[XmlArrayItem("string")]
		public List<string> IdentifyList
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
	}
}
