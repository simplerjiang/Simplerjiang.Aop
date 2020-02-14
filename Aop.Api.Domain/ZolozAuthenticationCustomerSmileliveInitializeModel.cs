using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZolozAuthenticationCustomerSmileliveInitializeModel : AopObject
	{
		[XmlElement("zimmetainfo")]
		public string Zimmetainfo
		{
			get;
			set;
		}
	}
}
