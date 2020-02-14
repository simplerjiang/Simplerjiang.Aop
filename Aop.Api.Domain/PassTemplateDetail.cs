using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PassTemplateDetail : AopObject
	{
		[XmlElement("create_time")]
		public string CreateTime
		{
			get;
			set;
		}

		[XmlElement("modify_time")]
		public string ModifyTime
		{
			get;
			set;
		}

		[XmlElement("tpl_content")]
		public string TplContent
		{
			get;
			set;
		}

		[XmlElement("tpl_id")]
		public string TplId
		{
			get;
			set;
		}

		[XmlArray("tpl_params")]
		[XmlArrayItem("string")]
		public List<string> TplParams
		{
			get;
			set;
		}
	}
}
