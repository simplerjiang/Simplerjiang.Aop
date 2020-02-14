using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserInfoAuthModel : AopObject
	{
		[XmlArray("scopes")]
		[XmlArrayItem("string")]
		public List<string> Scopes
		{
			get;
			set;
		}

		[XmlElement("state")]
		public string State
		{
			get;
			set;
		}
	}
}
