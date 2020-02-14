using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCdpAdvertiseCreateModel : AopObject
	{
		[XmlElement("action_url")]
		public string ActionUrl
		{
			get;
			set;
		}

		[XmlElement("ad_code")]
		public string AdCode
		{
			get;
			set;
		}

		[XmlElement("ad_rules")]
		public string AdRules
		{
			get;
			set;
		}

		[XmlElement("content")]
		public string Content
		{
			get;
			set;
		}

		[XmlElement("content_type")]
		public string ContentType
		{
			get;
			set;
		}

		[XmlElement("end_time")]
		public string EndTime
		{
			get;
			set;
		}

		[XmlElement("height")]
		public string Height
		{
			get;
			set;
		}

		[XmlElement("start_time")]
		public string StartTime
		{
			get;
			set;
		}
	}
}
