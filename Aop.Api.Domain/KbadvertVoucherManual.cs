using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbadvertVoucherManual : AopObject
	{
		[XmlArray("details")]
		[XmlArrayItem("string")]
		public List<string> Details
		{
			get;
			set;
		}

		[XmlElement("title")]
		public string Title
		{
			get;
			set;
		}
	}
}
