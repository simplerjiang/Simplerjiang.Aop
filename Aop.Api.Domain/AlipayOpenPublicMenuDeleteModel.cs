using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicMenuDeleteModel : AopObject
	{
		[XmlElement("menu_key")]
		public string MenuKey
		{
			get;
			set;
		}
	}
}
