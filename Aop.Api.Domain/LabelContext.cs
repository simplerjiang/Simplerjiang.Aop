using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class LabelContext : AopObject
	{
		[XmlElement("a")]
		public LabelFilter A
		{
			get;
			set;
		}
	}
}
