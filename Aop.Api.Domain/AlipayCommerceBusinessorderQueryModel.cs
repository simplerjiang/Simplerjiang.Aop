using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceBusinessorderQueryModel : AopObject
	{
		[XmlElement("begin_time")]
		public string BeginTime
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

		[XmlElement("isv_appid")]
		public string IsvAppid
		{
			get;
			set;
		}

		[XmlElement("page_num")]
		public string PageNum
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public string PageSize
		{
			get;
			set;
		}

		[XmlElement("platform_type")]
		public string PlatformType
		{
			get;
			set;
		}

		[XmlArray("status_list")]
		[XmlArrayItem("string")]
		public List<string> StatusList
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
	}
}
