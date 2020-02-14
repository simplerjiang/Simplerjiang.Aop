using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityProdXwbtestabcAbcQueryModel : AopObject
	{
		[XmlElement("xwb")]
		public string Xwb
		{
			get;
			set;
		}
	}
}
