using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class OpenPromoPrizeRelativeTime : AopObject
	{
		[XmlElement("dimension")]
		public string Dimension
		{
			get;
			set;
		}

		[XmlElement("value")]
		public string Value
		{
			get;
			set;
		}
	}
}
