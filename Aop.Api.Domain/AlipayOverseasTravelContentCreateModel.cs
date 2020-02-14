using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOverseasTravelContentCreateModel : AopObject
	{
		[XmlElement("author")]
		public string Author
		{
			get;
			set;
		}

		[XmlElement("category_code")]
		public string CategoryCode
		{
			get;
			set;
		}

		[XmlElement("category_name")]
		public string CategoryName
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

		[XmlElement("content_id")]
		public string ContentId
		{
			get;
			set;
		}

		[XmlElement("cover")]
		public string Cover
		{
			get;
			set;
		}

		[XmlElement("detail_url")]
		public string DetailUrl
		{
			get;
			set;
		}

		[XmlArray("image_list")]
		[XmlArrayItem("string")]
		public List<string> ImageList
		{
			get;
			set;
		}

		[XmlElement("modified_date")]
		public long ModifiedDate
		{
			get;
			set;
		}

		[XmlArray("poi_list")]
		[XmlArrayItem("content_poi_data")]
		public List<ContentPoiData> PoiList
		{
			get;
			set;
		}

		[XmlElement("publish_date")]
		public long PublishDate
		{
			get;
			set;
		}

		[XmlArray("tag_list")]
		[XmlArrayItem("string")]
		public List<string> TagList
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
	}
}
