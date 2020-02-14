using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class OpenPromoCamp : AopObject
	{
		[XmlElement("camp_alias")]
		public string CampAlias
		{
			get;
			set;
		}

		[XmlElement("camp_desc")]
		public string CampDesc
		{
			get;
			set;
		}

		[XmlElement("camp_end_time")]
		public string CampEndTime
		{
			get;
			set;
		}

		[XmlElement("camp_name")]
		public string CampName
		{
			get;
			set;
		}

		[XmlElement("camp_start_time")]
		public string CampStartTime
		{
			get;
			set;
		}

		[XmlElement("camp_type")]
		public string CampType
		{
			get;
			set;
		}
	}
}
