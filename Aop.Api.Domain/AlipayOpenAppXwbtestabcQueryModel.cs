using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenAppXwbtestabcQueryModel : AopObject
	{
		[XmlElement("testabc")]
		public string Testabc
		{
			get;
			set;
		}

		[XmlElement("xwb")]
		public string Xwb
		{
			get;
			set;
		}
	}
}
