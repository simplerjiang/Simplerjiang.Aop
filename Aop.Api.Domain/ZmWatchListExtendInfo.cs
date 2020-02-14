using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZmWatchListExtendInfo : AopObject
	{
		[XmlElement("description")]
		public string Description
		{
			get;
			set;
		}

		[XmlElement("key")]
		public string Key
		{
			get;
			set;
		}

		[XmlElement("value")]
		public string Value
		{
			get;
			set;
		}
	}
}
