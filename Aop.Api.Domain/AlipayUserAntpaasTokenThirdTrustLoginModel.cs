using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserAntpaasTokenThirdTrustLoginModel : AopObject
	{
		[XmlElement("login_target")]
		public string LoginTarget
		{
			get;
			set;
		}
	}
}
