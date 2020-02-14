using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class QueryInstBillDetail : AopObject
	{
		[XmlElement("key")]
		public string Key
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

		[XmlElement("value")]
		public string Value
		{
			get;
			set;
		}
	}
}
