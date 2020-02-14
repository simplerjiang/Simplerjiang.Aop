using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayBossBaseProcessSignVerifyModel : AopObject
	{
		[XmlElement("puid")]
		public string Puid
		{
			get;
			set;
		}

		[XmlElement("sign_content")]
		public string SignContent
		{
			get;
			set;
		}
	}
}
