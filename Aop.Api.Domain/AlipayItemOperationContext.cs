using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayItemOperationContext : AopObject
	{
		[XmlElement("creator")]
		public string Creator
		{
			get;
			set;
		}

		[XmlElement("op_role")]
		public string OpRole
		{
			get;
			set;
		}

		[XmlElement("partner_id")]
		public string PartnerId
		{
			get;
			set;
		}
	}
}
