using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenAppCodetesttestModel : AopObject
	{
		[XmlElement("testparam")]
		public string Testparam
		{
			get;
			set;
		}

		[XmlElement("testtestparam")]
		public string Testtestparam
		{
			get;
			set;
		}
	}
}
