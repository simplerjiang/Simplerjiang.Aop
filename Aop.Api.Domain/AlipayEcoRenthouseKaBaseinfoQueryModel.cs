using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoRenthouseKaBaseinfoQueryModel : AopObject
	{
		[XmlElement("ka_code")]
		public string KaCode
		{
			get;
			set;
		}
	}
}
