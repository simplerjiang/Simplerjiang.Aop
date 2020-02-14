using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class OpusInfo : AopObject
	{
		[XmlElement("display_weight")]
		public string DisplayWeight
		{
			get;
			set;
		}

		[XmlElement("external_opus_id")]
		public string ExternalOpusId
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

		[XmlElement("media_url")]
		public string MediaUrl
		{
			get;
			set;
		}

		[XmlElement("opus_id")]
		public string OpusId
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
