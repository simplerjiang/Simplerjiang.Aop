using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppProdmodeChargeoffinstQueryModel : AopObject
	{
		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}
	}
}
