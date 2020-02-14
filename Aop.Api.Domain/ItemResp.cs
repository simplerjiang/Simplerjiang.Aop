using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ItemResp : AopObject
	{
		[XmlElement("category")]
		public string Category
		{
			get;
			set;
		}

		[XmlElement("has_recive")]
		public bool HasRecive
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

		[XmlElement("image")]
		public string Image
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

		[XmlElement("meaning")]
		public string Meaning
		{
			get;
			set;
		}

		[XmlElement("price")]
		public string Price
		{
			get;
			set;
		}

		[XmlElement("summary")]
		public string Summary
		{
			get;
			set;
		}

		[XmlElement("tags")]
		public string Tags
		{
			get;
			set;
		}

		[XmlElement("tips")]
		public string Tips
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
