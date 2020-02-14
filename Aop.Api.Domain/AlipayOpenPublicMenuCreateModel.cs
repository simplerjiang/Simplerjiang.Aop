using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicMenuCreateModel : AopObject
	{
		[XmlArray("button")]
		[XmlArrayItem("button_object")]
		public List<ButtonObject> Button
		{
			get;
			set;
		}

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}
	}
}
