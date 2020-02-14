using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayZmScoreZrankResult : AopObject
	{
		[XmlElement("zrank")]
		public string Zrank
		{
			get;
			set;
		}
	}
}
