using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class VoucherTemplateLiteInfo : AopObject
	{
		[XmlElement("activate_time")]
		public string ActivateTime
		{
			get;
			set;
		}

		[XmlElement("create_time")]
		public string CreateTime
		{
			get;
			set;
		}

		[XmlElement("publish_end_time")]
		public string PublishEndTime
		{
			get;
			set;
		}

		[XmlElement("publish_start_time")]
		public string PublishStartTime
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

		[XmlElement("template_id")]
		public string TemplateId
		{
			get;
			set;
		}

		[XmlElement("voucher_name")]
		public string VoucherName
		{
			get;
			set;
		}
	}
}
