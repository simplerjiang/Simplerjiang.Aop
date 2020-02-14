using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FengdieSpaceDetailModel : AopObject
	{
		[XmlArray("domains")]
		[XmlArrayItem("fengdie_space_domains")]
		public List<FengdieSpaceDomains> Domains
		{
			get;
			set;
		}

		[XmlElement("gmt_create")]
		public string GmtCreate
		{
			get;
			set;
		}

		[XmlElement("space_id")]
		public string SpaceId
		{
			get;
			set;
		}

		[XmlElement("title")]
		public string Title
		{
			get;
			set;
		}
	}
}
