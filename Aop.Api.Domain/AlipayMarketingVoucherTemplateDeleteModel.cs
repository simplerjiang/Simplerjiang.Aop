using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingVoucherTemplateDeleteModel : AopObject
	{
		[XmlElement("template_id")]
		public string TemplateId
		{
			get;
			set;
		}
	}
}
