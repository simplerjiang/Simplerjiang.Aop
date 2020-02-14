using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class NewsfeedMediaImg : AopObject
	{
		[XmlElement("height")]
		public string Height
		{
			get;
			set;
		}

		[XmlElement("src")]
		public string Src
		{
			get;
			set;
		}

		[XmlElement("width")]
		public string Width
		{
			get;
			set;
		}
	}
}
