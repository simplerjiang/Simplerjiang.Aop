using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MyObjectDdd : AopObject
	{
		[XmlElement("item")]
		public string Item
		{
			get;
			set;
		}

		[XmlElement("param")]
		public string Param
		{
			get;
			set;
		}
	}
}
