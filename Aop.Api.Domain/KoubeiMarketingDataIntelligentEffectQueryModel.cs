using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingDataIntelligentEffectQueryModel : AopObject
	{
		[XmlElement("operator_context")]
		public PromoOperatorInfo OperatorContext
		{
			get;
			set;
		}

		[XmlElement("out_request_no")]
		public string OutRequestNo
		{
			get;
			set;
		}

		[XmlElement("promo")]
		public IntelligentPromo Promo
		{
			get;
			set;
		}
	}
}
