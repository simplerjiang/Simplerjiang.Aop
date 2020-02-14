using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CraftsmanWorkOpenModel : AopObject
	{
		[XmlElement("craftsman_id")]
		public string CraftsmanId
		{
			get;
			set;
		}

		[XmlElement("duration")]
		public long Duration
		{
			get;
			set;
		}

		[XmlElement("media_id")]
		public string MediaId
		{
			get;
			set;
		}

		[XmlElement("media_type")]
		public string MediaType
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
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

		[XmlElement("work_id")]
		public string WorkId
		{
			get;
			set;
		}
	}
}
