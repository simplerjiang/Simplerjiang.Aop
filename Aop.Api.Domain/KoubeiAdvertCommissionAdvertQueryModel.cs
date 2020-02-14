using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiAdvertCommissionAdvertQueryModel : AopObject
	{
		[XmlArray("identifies")]
		[XmlArrayItem("string")]
		public List<string> Identifies
		{
			get;
			set;
		}

		[XmlElement("identify_type")]
		public string IdentifyType
		{
			get;
			set;
		}
	}
}
