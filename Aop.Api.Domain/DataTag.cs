using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DataTag : AopObject
	{
		[XmlElement("aggregate")]
		public string Aggregate
		{
			get;
			set;
		}

		[XmlElement("alias")]
		public string Alias
		{
			get;
			set;
		}

		[XmlElement("code")]
		public string Code
		{
			get;
			set;
		}
	}
}
