using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InteligentDataCondition : AopObject
	{
		[XmlElement("data_type")]
		public string DataType
		{
			get;
			set;
		}

		[XmlElement("limit_type")]
		public string LimitType
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
