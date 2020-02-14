using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingAdvertisingModifyModel : AopObject
	{
		[XmlElement("action_url")]
		public string ActionUrl
		{
			get;
			set;
		}

		[XmlElement("ad_id")]
		public string AdId
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
