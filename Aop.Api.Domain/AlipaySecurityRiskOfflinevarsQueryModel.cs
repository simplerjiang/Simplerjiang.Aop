using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityRiskOfflinevarsQueryModel : AopObject
	{
		[XmlElement("rowkeys")]
		public string Rowkeys
		{
			get;
			set;
		}
	}
}
