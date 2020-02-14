using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class RetailKbcodeQueryVo : AopObject
	{
		[XmlElement("batch_id")]
		public string BatchId
		{
			get;
			set;
		}

		[XmlElement("code_template")]
		public string CodeTemplate
		{
			get;
			set;
		}

		[XmlElement("code_tip")]
		public string CodeTip
		{
			get;
			set;
		}

		[XmlElement("code_url")]
		public string CodeUrl
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

		[XmlElement("qr_code")]
		public string QrCode
		{
			get;
			set;
		}

		[XmlElement("resource_url")]
		public string ResourceUrl
		{
			get;
			set;
		}

		[XmlElement("salesman")]
		public string Salesman
		{
			get;
			set;
		}
	}
}
