using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class TemplateColumnInfoDTO : AopObject
	{
		[XmlElement("code")]
		public string Code
		{
			get;
			set;
		}

		[XmlElement("group_title")]
		public string GroupTitle
		{
			get;
			set;
		}

		[XmlElement("icon_id")]
		public string IconId
		{
			get;
			set;
		}

		[XmlElement("more_info")]
		public MoreInfoDTO MoreInfo
		{
			get;
			set;
		}

		[XmlElement("operate_type")]
		public string OperateType
		{
			get;
			set;
		}

		[XmlElement("tag")]
		public string Tag
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

		[XmlElement("value")]
		public string Value
		{
			get;
			set;
		}
	}
}
