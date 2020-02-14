using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CodeInfo : AopObject
	{
		[XmlElement("goto_url")]
		public string GotoUrl
		{
			get;
			set;
		}

		[XmlElement("scene")]
		public Scene Scene
		{
			get;
			set;
		}
	}
}
