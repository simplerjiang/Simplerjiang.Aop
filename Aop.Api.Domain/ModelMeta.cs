using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ModelMeta : AopObject
	{
		[XmlElement("model_desc")]
		public string ModelDesc
		{
			get;
			set;
		}

		[XmlElement("model_name")]
		public string ModelName
		{
			get;
			set;
		}

		[XmlElement("model_uk")]
		public string ModelUk
		{
			get;
			set;
		}

		[XmlArray("query_key")]
		[XmlArrayItem("string")]
		public List<string> QueryKey
		{
			get;
			set;
		}
	}
}
