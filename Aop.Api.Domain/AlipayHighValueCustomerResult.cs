using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayHighValueCustomerResult : AopObject
	{
		[XmlElement("level")]
		public string Level
		{
			get;
			set;
		}
	}
}
