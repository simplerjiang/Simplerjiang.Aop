using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class RecItemInfo : AopObject
	{
		[XmlElement("area_code")]
		public string AreaCode
		{
			get;
			set;
		}

		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("description")]
		public string Description
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("icon")]
		public string Icon
		{
			get;
			set;
		}

		[XmlElement("item_code")]
		public string ItemCode
		{
			get;
			set;
		}

		[XmlElement("item_id")]
		public string ItemId
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}

		[XmlElement("service_code")]
		public string ServiceCode
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

		[XmlElement("type")]
		public string Type
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
