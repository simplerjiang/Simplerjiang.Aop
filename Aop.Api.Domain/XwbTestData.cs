using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class XwbTestData : AopObject
	{
		[XmlElement("s")]
		public string S
		{
			get;
			set;
		}
	}
}
