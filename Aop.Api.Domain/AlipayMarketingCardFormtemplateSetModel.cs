using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCardFormtemplateSetModel : AopObject
	{
		[XmlElement("fields")]
		public OpenFormFieldDO Fields
		{
			get;
			set;
		}

		[XmlElement("template_id")]
		public string TemplateId
		{
			get;
			set;
		}
	}
}
