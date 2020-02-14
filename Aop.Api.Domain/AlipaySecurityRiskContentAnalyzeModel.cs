using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityRiskContentAnalyzeModel : AopObject
	{
		[XmlElement("account_id")]
		public string AccountId
		{
			get;
			set;
		}

		[XmlElement("account_type")]
		public string AccountType
		{
			get;
			set;
		}

		[XmlElement("app_main_scene")]
		public string AppMainScene
		{
			get;
			set;
		}

		[XmlElement("app_main_scene_id")]
		public string AppMainSceneId
		{
			get;
			set;
		}

		[XmlElement("app_name")]
		public string AppName
		{
			get;
			set;
		}

		[XmlElement("app_scene")]
		public string AppScene
		{
			get;
			set;
		}

		[XmlElement("app_scene_data_id")]
		public string AppSceneDataId
		{
			get;
			set;
		}

		[XmlArray("audio_urls")]
		[XmlArrayItem("string")]
		public List<string> AudioUrls
		{
			get;
			set;
		}

		[XmlArray("link_urls")]
		[XmlArrayItem("string")]
		public List<string> LinkUrls
		{
			get;
			set;
		}

		[XmlArray("picture_urls")]
		[XmlArrayItem("string")]
		public List<string> PictureUrls
		{
			get;
			set;
		}

		[XmlElement("publish_date")]
		public string PublishDate
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

		[XmlArray("video_urls")]
		[XmlArrayItem("string")]
		public List<string> VideoUrls
		{
			get;
			set;
		}
	}
}
