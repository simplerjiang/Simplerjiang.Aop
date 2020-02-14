using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayPassTemplateUpdateModel : AopObject
	{
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
	}
}
