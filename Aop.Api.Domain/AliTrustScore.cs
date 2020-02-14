using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AliTrustScore : AopObject
	{
		[XmlElement("score")]
		public long Score
		{
			get;
			set;
		}
	}
}
