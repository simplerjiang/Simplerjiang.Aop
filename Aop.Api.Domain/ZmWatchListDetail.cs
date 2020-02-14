using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZmWatchListDetail : AopObject
	{
		[XmlElement("biz_code")]
		public string BizCode
		{
			get;
			set;
		}

		[XmlElement("code")]
		public string Code
		{
			get;
			set;
		}

		[XmlArray("extend_info")]
		[XmlArrayItem("zm_watch_list_extend_info")]
		public List<ZmWatchListExtendInfo> ExtendInfo
		{
			get;
			set;
		}

		[XmlElement("level")]
		public long Level
		{
			get;
			set;
		}

		[XmlElement("refresh_time")]
		public string RefreshTime
		{
			get;
			set;
		}

		[XmlElement("settlement")]
		public bool Settlement
		{
			get;
			set;
		}

		[XmlElement("statement")]
		public string Statement
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
	}
}
