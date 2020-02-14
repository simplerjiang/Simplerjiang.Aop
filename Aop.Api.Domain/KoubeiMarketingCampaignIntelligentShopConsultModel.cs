using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingCampaignIntelligentShopConsultModel : AopObject
	{
		[XmlElement("biz_scene")]
		public string BizScene
		{
			get;
			set;
		}

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

		[XmlElement("page_index")]
		public string PageIndex
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public string PageSize
		{
			get;
			set;
		}

		[XmlElement("partner_id")]
		public string PartnerId
		{
			get;
			set;
		}

		[XmlElement("plan_id")]
		public string PlanId
		{
			get;
			set;
		}

		[XmlElement("promo_id")]
		public string PromoId
		{
			get;
			set;
		}

		[XmlElement("template_code")]
		public string TemplateCode
		{
			get;
			set;
		}
	}
}
