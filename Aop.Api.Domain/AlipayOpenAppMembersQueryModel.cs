using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenAppMembersQueryModel : AopObject
	{
		[XmlElement("role")]
		public string Role
		{
			get;
			set;
		}
	}
}
