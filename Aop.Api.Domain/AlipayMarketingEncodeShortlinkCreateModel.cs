using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingEncodeShortlinkCreateModel : AopObject
	{
		[XmlElement("biz_identifier")]
		public string BizIdentifier
		{
			get;
			set;
		}

		[XmlElement("encode_url")]
		public string EncodeUrl
		{
			get;
			set;
		}

		[XmlElement("timeout")]
		public string Timeout
		{
			get;
			set;
		}
	}
}
