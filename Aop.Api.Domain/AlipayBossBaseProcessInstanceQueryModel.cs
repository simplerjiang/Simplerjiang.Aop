using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayBossBaseProcessInstanceQueryModel : AopObject
	{
		[XmlElement("puid")]
		public string Puid
		{
			get;
			set;
		}
	}
}
