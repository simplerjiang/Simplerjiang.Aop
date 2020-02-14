using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicMatchuserLabelDeleteModel : AopObject
	{
		[XmlElement("label_id")]
		public string LabelId
		{
			get;
			set;
		}

		[XmlArray("matchers")]
		[XmlArrayItem("matcher")]
		public List<Matcher> Matchers
		{
			get;
			set;
		}
	}
}
