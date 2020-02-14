using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class QueryResult : AopObject
	{
		[XmlElement("background_url")]
		public string BackgroundUrl
		{
			get;
			set;
		}

		[XmlElement("brand_id")]
		public string BrandId
		{
			get;
			set;
		}

		[XmlElement("brand_name")]
		public string BrandName
		{
			get;
			set;
		}

		[XmlElement("cc")]
		public string Cc
		{
			get;
			set;
		}

		[XmlElement("company_id")]
		public string CompanyId
		{
			get;
			set;
		}

		[XmlElement("company_name")]
		public string CompanyName
		{
			get;
			set;
		}

		[XmlElement("engine")]
		public string Engine
		{
			get;
			set;
		}

		[XmlElement("logo_url")]
		public string LogoUrl
		{
			get;
			set;
		}

		[XmlElement("model_id")]
		public string ModelId
		{
			get;
			set;
		}

		[XmlElement("model_name")]
		public string ModelName
		{
			get;
			set;
		}

		[XmlElement("prod_year")]
		public string ProdYear
		{
			get;
			set;
		}

		[XmlElement("serie_group")]
		public string SerieGroup
		{
			get;
			set;
		}

		[XmlElement("serie_id")]
		public string SerieId
		{
			get;
			set;
		}

		[XmlElement("serie_name")]
		public string SerieName
		{
			get;
			set;
		}

		[XmlElement("serie_photo")]
		public string SeriePhoto
		{
			get;
			set;
		}

		[XmlElement("style")]
		public string Style
		{
			get;
			set;
		}
	}
}
