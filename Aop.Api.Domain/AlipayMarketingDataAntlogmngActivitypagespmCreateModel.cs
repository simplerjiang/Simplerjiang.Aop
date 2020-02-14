using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingDataAntlogmngActivitypagespmCreateModel : AopObject
	{
		[XmlElement("activity_id")]
		public string ActivityId
		{
			get;
			set;
		}

		[XmlElement("owner")]
		public string Owner
		{
			get;
			set;
		}

		[XmlElement("spma")]
		public string Spma
		{
			get;
			set;
		}

		[XmlElement("spmb")]
		public string Spmb
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

		[XmlElement("url")]
		public string Url
		{
			get;
			set;
		}
	}
}
