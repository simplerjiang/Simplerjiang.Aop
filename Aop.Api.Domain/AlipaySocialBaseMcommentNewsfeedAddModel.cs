using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySocialBaseMcommentNewsfeedAddModel : AopObject
	{
		[XmlElement("activity_address")]
		public string ActivityAddress
		{
			get;
			set;
		}

		[XmlElement("activity_name")]
		public string ActivityName
		{
			get;
			set;
		}

		[XmlElement("aid")]
		public string Aid
		{
			get;
			set;
		}

		[XmlElement("biz_no")]
		public string BizNo
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

		[XmlElement("gift_info")]
		public NewsfeedMediaGiftInfo GiftInfo
		{
			get;
			set;
		}

		[XmlArray("img_infos")]
		[XmlArrayItem("newsfeed_media_img")]
		public List<NewsfeedMediaImg> ImgInfos
		{
			get;
			set;
		}

		[XmlElement("label_info")]
		public NewsfeedLabelInfo LabelInfo
		{
			get;
			set;
		}

		[XmlElement("link_info")]
		public NewsfeedMediaLinkInfo LinkInfo
		{
			get;
			set;
		}

		[XmlElement("location_info")]
		public NewsfeedLocationInfo LocationInfo
		{
			get;
			set;
		}

		[XmlElement("location_name")]
		public string LocationName
		{
			get;
			set;
		}

		[XmlElement("location_scheme")]
		public string LocationScheme
		{
			get;
			set;
		}

		[XmlElement("scene_code")]
		public string SceneCode
		{
			get;
			set;
		}

		[XmlElement("score")]
		public long Score
		{
			get;
			set;
		}

		[XmlElement("source")]
		public string Source
		{
			get;
			set;
		}

		[XmlElement("source_icon")]
		public string SourceIcon
		{
			get;
			set;
		}

		[XmlElement("source_name")]
		public string SourceName
		{
			get;
			set;
		}

		[XmlElement("spread_range")]
		public long SpreadRange
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

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}

		[XmlElement("video_info")]
		public NewsfeedMediaVideoInfo VideoInfo
		{
			get;
			set;
		}

		[XmlElement("visible")]
		public long Visible
		{
			get;
			set;
		}

		[XmlArray("visible_range")]
		[XmlArrayItem("string")]
		public List<string> VisibleRange
		{
			get;
			set;
		}

		[XmlArray("with_me")]
		[XmlArrayItem("newsfeed_with_me_info")]
		public List<NewsfeedWithMeInfo> WithMe
		{
			get;
			set;
		}
	}
}
