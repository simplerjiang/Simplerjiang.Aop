using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbCodeInfoVO : AopObject
	{
		[XmlElement("batch_id")]
		public long BatchId
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

		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}

		[XmlElement("shop_name")]
		public string ShopName
		{
			get;
			set;
		}

		[XmlElement("stuff_template")]
		public string StuffTemplate
		{
			get;
			set;
		}

		[XmlElement("stuff_template_desc")]
		public string StuffTemplateDesc
		{
			get;
			set;
		}

		[XmlElement("stuff_type_desc")]
		public string StuffTypeDesc
		{
			get;
			set;
		}

		[XmlElement("table_no")]
		public string TableNo
		{
			get;
			set;
		}
	}
}
