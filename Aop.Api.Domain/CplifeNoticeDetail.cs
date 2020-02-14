using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CplifeNoticeDetail : AopObject
	{
		[XmlElement("content")]
		public string Content
		{
			get;
			set;
		}

		[XmlElement("end_time")]
		public string EndTime
		{
			get;
			set;
		}

		[XmlArray("image_list")]
		[XmlArrayItem("cplife_notice_img")]
		public List<CplifeNoticeImg> ImageList
		{
			get;
			set;
		}

		[XmlElement("start_time")]
		public string StartTime
		{
			get;
			set;
		}

		[XmlElement("stickied")]
		public bool Stickied
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
	}
}
