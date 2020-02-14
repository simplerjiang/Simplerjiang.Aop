using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ContentPicture : AopObject
	{
		[XmlElement("location")]
		public string Location
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
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
