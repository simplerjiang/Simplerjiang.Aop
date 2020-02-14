using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class IntelligentPromoDetail : AopObject
	{
		[XmlElement("budget")]
		public BudgetInfo Budget
		{
			get;
			set;
		}

		[XmlElement("camp_id")]
		public string CampId
		{
			get;
			set;
		}

		[XmlElement("constraint")]
		public ConstraintInfo Constraint
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

		[XmlArray("promo_tools")]
		[XmlArrayItem("promo_tool")]
		public List<PromoTool> PromoTools
		{
			get;
			set;
		}

		[XmlArray("publish_channels")]
		[XmlArrayItem("publish_channel")]
		public List<PublishChannel> PublishChannels
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
