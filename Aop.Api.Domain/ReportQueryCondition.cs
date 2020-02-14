using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ReportQueryCondition : AopObject
	{
		[XmlElement("key")]
		public string Key
		{
			get;
			set;
		}

		[XmlElement("operate")]
		public string Operate
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
