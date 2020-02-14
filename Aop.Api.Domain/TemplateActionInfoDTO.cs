using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class TemplateActionInfoDTO : AopObject
	{
		[XmlElement("code")]
		public string Code
		{
			get;
			set;
		}

		[XmlElement("mini_app_url")]
		public TemplateActionMiniAppUrlDTO MiniAppUrl
		{
			get;
			set;
		}

		[XmlElement("text")]
		public string Text
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

		[XmlElement("url_type")]
		public string UrlType
		{
			get;
			set;
		}
	}
}
