using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayAccountExrateAdviceAcceptModel : AopObject
	{
		[XmlElement("advice")]
		public AdviceVO Advice
		{
			get;
			set;
		}
	}
}
