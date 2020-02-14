using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenAppMiniTemplatemessageSendModel : AopObject
	{
		[XmlElement("data")]
		public string Data
		{
			get;
			set;
		}

		[XmlElement("form_id")]
		public string FormId
		{
			get;
			set;
		}

		[XmlElement("page")]
		public string Page
		{
			get;
			set;
		}

		[XmlElement("to_user_id")]
		public string ToUserId
		{
			get;
			set;
		}

		[XmlElement("user_template_id")]
		public string UserTemplateId
		{
			get;
			set;
		}
	}
}
