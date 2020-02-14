using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ProducerVO : AopObject
	{
		[XmlElement("biz_status")]
		public string BizStatus
		{
			get;
			set;
		}

		[XmlElement("business_desc")]
		public string BusinessDesc
		{
			get;
			set;
		}

		[XmlElement("certificate_desc")]
		public string CertificateDesc
		{
			get;
			set;
		}

		[XmlElement("producer_id")]
		public string ProducerId
		{
			get;
			set;
		}

		[XmlElement("producer_name")]
		public string ProducerName
		{
			get;
			set;
		}

		[XmlElement("short_code")]
		public string ShortCode
		{
			get;
			set;
		}
	}
}
