using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class HoloGraphicContactInfo : AopObject
	{
		[XmlElement("call_frequency")]
		public long CallFrequency
		{
			get;
			set;
		}

		[XmlElement("call_time")]
		public long CallTime
		{
			get;
			set;
		}

		[XmlElement("called_frequency")]
		public long CalledFrequency
		{
			get;
			set;
		}

		[XmlElement("called_time")]
		public long CalledTime
		{
			get;
			set;
		}

		[XmlElement("mobile")]
		public string Mobile
		{
			get;
			set;
		}

		[XmlElement("talk_frequency")]
		public long TalkFrequency
		{
			get;
			set;
		}

		[XmlElement("talk_time")]
		public long TalkTime
		{
			get;
			set;
		}
	}
}
