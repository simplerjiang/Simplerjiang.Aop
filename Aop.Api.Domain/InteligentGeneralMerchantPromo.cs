using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InteligentGeneralMerchantPromo : AopObject
	{
		[XmlElement("camp_id")]
		public string CampId
		{
			get;
			set;
		}

		[XmlElement("crowd_constraint")]
		public CrowdConstraintInfo CrowdConstraint
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

		[XmlElement("inteligent_budget")]
		public InteligentBudgetInfo InteligentBudget
		{
			get;
			set;
		}

		[XmlElement("inteligent_constraint")]
		public InteligentConstraintInfo InteligentConstraint
		{
			get;
			set;
		}

		[XmlArray("inteligent_promo_tools")]
		[XmlArrayItem("inteligent_promo_tool")]
		public List<InteligentPromoTool> InteligentPromoTools
		{
			get;
			set;
		}

		[XmlArray("inteligent_publish_channels")]
		[XmlArrayItem("inteligent_publish_channel")]
		public List<InteligentPublishChannel> InteligentPublishChannels
		{
			get;
			set;
		}

		[XmlElement("merchant_promo_type")]
		public string MerchantPromoType
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

		[XmlElement("template_id")]
		public string TemplateId
		{
			get;
			set;
		}
	}
}
