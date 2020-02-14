using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingToolFengdieActivityCreateModel : AopObject
	{
		[XmlElement("activity")]
		public FengdieActivityCreateData Activity
		{
			get;
			set;
		}

		[XmlElement("template_id")]
		public long TemplateId
		{
			get;
			set;
		}
	}
}
