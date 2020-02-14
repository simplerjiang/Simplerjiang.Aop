using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CraftsmanWorkCreateOpenModel : AopObject
	{
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

		[XmlElement("out_work_id")]
		public string OutWorkId
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
