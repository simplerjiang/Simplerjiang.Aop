using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoRenthouseKaBaseinfoSyncModel : AopObject
	{
		[XmlElement("ka_code")]
		public string KaCode
		{
			get;
			set;
		}

		[XmlElement("ka_name")]
		public string KaName
		{
			get;
			set;
		}
	}
}
