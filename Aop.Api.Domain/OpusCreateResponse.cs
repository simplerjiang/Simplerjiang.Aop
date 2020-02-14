using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class OpusCreateResponse : AopObject
	{
		[XmlElement("external_opus_id")]
		public string ExternalOpusId
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
	}
}
