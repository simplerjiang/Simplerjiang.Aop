using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SignResultValue : AopObject
	{
		[XmlElement("effect_biz_value")]
		public string EffectBizValue
		{
			get;
			set;
		}
	}
}
