using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsAutoAutoinsprodCommonConsultModel : AopObject
	{
		[XmlElement("biz_data")]
		public string BizData
		{
			get;
			set;
		}

		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}
	}
}
