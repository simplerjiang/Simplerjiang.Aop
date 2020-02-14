using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class TemplateMdcodeNotifyConfDTO : AopObject
	{
		[XmlElement("ext_params")]
		public string ExtParams
		{
			get;
			set;
		}

		[XmlElement("url")]
		public string Url
		{
			get;
			set;
		}
	}
}
