using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InteligentForbiddenTime : AopObject
	{
		[XmlElement("days")]
		public string Days
		{
			get;
			set;
		}
	}
}
