using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayDataDataserviceCodeRecoModel : AopObject
	{
		[XmlElement("config")]
		public string Config
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

		[XmlElement("strategy")]
		public string Strategy
		{
			get;
			set;
		}
	}
}
