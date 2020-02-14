using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZolozAuthenticationCustomerSmilepayInitializeModel : AopObject
	{
		[XmlElement("zimmetainfo")]
		public string Zimmetainfo
		{
			get;
			set;
		}
	}
}
