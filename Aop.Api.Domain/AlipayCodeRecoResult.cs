using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCodeRecoResult : AopObject
	{
		[XmlElement("content")]
		public string Content
		{
			get;
			set;
		}
	}
}
