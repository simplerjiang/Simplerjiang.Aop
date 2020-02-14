using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ExtItem : AopObject
	{
		[XmlElement("brand_code")]
		public string BrandCode
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

		[XmlElement("count")]
		public long Count
		{
			get;
			set;
		}

		[XmlElement("country")]
		public string Country
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

		[XmlElement("id")]
		public long Id
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

		[XmlElement("picture")]
		public string Picture
		{
			get;
			set;
		}

		[XmlElement("price")]
		public long Price
		{
			get;
			set;
		}

		[XmlElement("specification")]
		public string Specification
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
