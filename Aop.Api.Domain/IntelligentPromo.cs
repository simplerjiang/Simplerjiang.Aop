using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class IntelligentPromo : AopObject
	{
		[XmlElement("allow_auto_delay")]
		public bool AllowAutoDelay
		{
			get;
			set;
		}

		[XmlElement("audit_status")]
		public string AuditStatus
		{
			get;
			set;
		}

		[XmlElement("create_request_no")]
		public string CreateRequestNo
		{
			get;
			set;
		}

		[XmlElement("creator_info")]
		public PromoOperatorInfo CreatorInfo
		{
			get;
			set;
		}

		[XmlElement("desc")]
		public string Desc
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("forecast_effect")]
		public IntelligentPromoEffect ForecastEffect
		{
			get;
			set;
		}

		[XmlElement("gmt_closed")]
		public string GmtClosed
		{
			get;
			set;
		}

		[XmlElement("gmt_enabled")]
		public string GmtEnabled
		{
			get;
			set;
		}

		[XmlElement("gmt_end")]
		public string GmtEnd
		{
			get;
			set;
		}

		[XmlElement("gmt_start")]
		public string GmtStart
		{
			get;
			set;
		}

		[XmlArray("merchant_promos")]
		[XmlArrayItem("inteligent_merchant_promo")]
		public List<InteligentMerchantPromo> MerchantPromos
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}

		[XmlElement("owner_info")]
		public PromoOperatorInfo OwnerInfo
		{
			get;
			set;
		}

		[XmlElement("parent_promo_id")]
		public string ParentPromoId
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

		[XmlArray("promos")]
		[XmlArrayItem("intelligent_promo_detail")]
		public List<IntelligentPromoDetail> Promos
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlArray("sub_promo_ids")]
		[XmlArrayItem("string")]
		public List<string> SubPromoIds
		{
			get;
			set;
		}

		[XmlElement("sub_status")]
		public string SubStatus
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

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}
	}
}
