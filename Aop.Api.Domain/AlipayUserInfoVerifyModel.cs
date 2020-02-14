using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserInfoVerifyModel : AopObject
	{
		[XmlElement("request")]
		public string Request
		{
			get;
			set;
		}
	}
}
