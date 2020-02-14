using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayKeyanClass : AopObject
	{
		[XmlElement("user_name")]
		public string UserName
		{
			get;
			set;
		}
	}
}
