using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenAppYufalingsanyaowubYufalingsanyaowubQueryModel : AopObject
	{
		[XmlElement("yufaa")]
		public string Yufaa
		{
			get;
			set;
		}
	}
}
