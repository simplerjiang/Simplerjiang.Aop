using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicMatchuserLabelCreateModel : AopObject
	{
		[XmlElement("label_id")]
		public string LabelId
		{
			get;
			set;
		}

		[XmlElement("label_value")]
		public string LabelValue
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
