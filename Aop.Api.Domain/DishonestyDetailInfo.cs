using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DishonestyDetailInfo : AopObject
	{
		[XmlElement("behavior")]
		public string Behavior
		{
			get;
			set;
		}

		[XmlElement("case_code")]
		public string CaseCode
		{
			get;
			set;
		}

		[XmlElement("enforce_court")]
		public string EnforceCourt
		{
			get;
			set;
		}

		[XmlElement("id_number")]
		public string IdNumber
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

		[XmlElement("performance")]
		public string Performance
		{
			get;
			set;
		}

		[XmlElement("publish_date")]
		public string PublishDate
		{
			get;
			set;
		}

		[XmlElement("region")]
		public string Region
		{
			get;
			set;
		}
	}
}
