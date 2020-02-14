using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CampDetailInfo : AopObject
	{
		[XmlElement("begin_time")]
		public string BeginTime
		{
			get;
			set;
		}

		[XmlElement("biz_id")]
		public string BizId
		{
			get;
			set;
		}

		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("camp_desc")]
		public string CampDesc
		{
			get;
			set;
		}

		[XmlElement("camp_guide")]
		public string CampGuide
		{
			get;
			set;
		}

		[XmlElement("camp_id")]
		public string CampId
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

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlArray("rule_flag_list")]
		[XmlArrayItem("string")]
		public List<string> RuleFlagList
		{
			get;
			set;
		}

		[XmlElement("win_limit_daily")]
		public string WinLimitDaily
		{
			get;
			set;
		}

		[XmlElement("win_limit_life")]
		public string WinLimitLife
		{
			get;
			set;
		}
	}
}
