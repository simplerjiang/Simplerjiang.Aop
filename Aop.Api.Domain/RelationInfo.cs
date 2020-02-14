using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class RelationInfo : AopObject
	{
		[XmlElement("recency")]
		public string Recency
		{
			get;
			set;
		}
	}
}
