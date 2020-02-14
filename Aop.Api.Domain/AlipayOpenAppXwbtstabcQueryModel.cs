using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenAppXwbtstabcQueryModel : AopObject
	{
		[XmlElement("xwbaa")]
		public string Xwbaa
		{
			get;
			set;
		}
	}
}
