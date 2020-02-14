using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class NewsfeedMediaGiftInfo : AopObject
	{
		[XmlElement("action")]
		public string Action
		{
			get;
			set;
		}

		[XmlElement("adr_height")]
		public string AdrHeight
		{
			get;
			set;
		}

		[XmlElement("adr_thumb")]
		public string AdrThumb
		{
			get;
			set;
		}

		[XmlElement("adr_width")]
		public string AdrWidth
		{
			get;
			set;
		}

		[XmlElement("ios_height")]
		public string IosHeight
		{
			get;
			set;
		}

		[XmlElement("ios_thumb")]
		public string IosThumb
		{
			get;
			set;
		}

		[XmlElement("ios_width")]
		public string IosWidth
		{
			get;
			set;
		}

		[XmlElement("theme")]
		public string Theme
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
