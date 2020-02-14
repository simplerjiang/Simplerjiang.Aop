using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DataSecCheckContent : AopObject
	{
		[XmlElement("data_id")]
		public string DataId
		{
			get;
			set;
		}

		[XmlElement("scene_type")]
		public string SceneType
		{
			get;
			set;
		}

		[XmlElement("text")]
		public string Text
		{
			get;
			set;
		}

		[XmlArray("urls")]
		[XmlArrayItem("string")]
		public List<string> Urls
		{
			get;
			set;
		}
	}
}
