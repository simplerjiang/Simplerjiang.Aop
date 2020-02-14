using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class IotDeviceModel : AopObject
	{
		[XmlElement("category_id")]
		public string CategoryId
		{
			get;
			set;
		}

		[XmlArray("connection_types")]
		[XmlArrayItem("string")]
		public List<string> ConnectionTypes
		{
			get;
			set;
		}

		[XmlElement("connection_url")]
		public string ConnectionUrl
		{
			get;
			set;
		}

		[XmlElement("decription")]
		public string Decription
		{
			get;
			set;
		}

		[XmlElement("icon")]
		public string Icon
		{
			get;
			set;
		}

		[XmlElement("manufacturer")]
		public string Manufacturer
		{
			get;
			set;
		}

		[XmlElement("model_id")]
		public string ModelId
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
	}
}
