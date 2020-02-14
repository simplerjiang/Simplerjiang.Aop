using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class VoucherTermInfo : AopObject
	{
		[XmlArray("descriptions")]
		[XmlArrayItem("string")]
		public List<string> Descriptions
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
