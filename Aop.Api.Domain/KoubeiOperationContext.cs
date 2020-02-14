using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiOperationContext : AopObject
	{
		[XmlElement("op_role")]
		public string OpRole
		{
			get;
			set;
		}
	}
}
