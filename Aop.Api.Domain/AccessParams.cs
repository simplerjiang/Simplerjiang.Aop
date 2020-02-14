using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AccessParams : AopObject
	{
		[XmlElement("channel")]
		public string Channel
		{
			get;
			set;
		}
	}
}
