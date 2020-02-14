using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class TemplateStyleInfoDTO : AopObject
	{
		[XmlElement("background_id")]
		public string BackgroundId
		{
			get;
			set;
		}

		[XmlElement("banner_img_id")]
		public string BannerImgId
		{
			get;
			set;
		}

		[XmlElement("banner_url")]
		public string BannerUrl
		{
			get;
			set;
		}

		[XmlElement("bg_color")]
		public string BgColor
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

		[XmlElement("card_show_name")]
		public string CardShowName
		{
			get;
			set;
		}

		[XmlElement("color")]
		public string Color
		{
			get;
			set;
		}

		[XmlElement("column_info_layout")]
		public string ColumnInfoLayout
		{
			get;
			set;
		}

		[XmlArray("feature_descriptions")]
		[XmlArrayItem("string")]
		public List<string> FeatureDescriptions
		{
			get;
			set;
		}

		[XmlElement("front_image_enable")]
		public bool FrontImageEnable
		{
			get;
			set;
		}

		[XmlElement("front_text_list_enable")]
		public bool FrontTextListEnable
		{
			get;
			set;
		}

		[XmlElement("logo_id")]
		public string LogoId
		{
			get;
			set;
		}

		[XmlElement("slogan")]
		public string Slogan
		{
			get;
			set;
		}

		[XmlElement("slogan_img_id")]
		public string SloganImgId
		{
			get;
			set;
		}
	}
}
