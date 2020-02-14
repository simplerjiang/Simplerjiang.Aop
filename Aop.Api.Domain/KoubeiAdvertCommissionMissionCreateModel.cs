using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiAdvertCommissionMissionCreateModel : AopObject
	{
		[XmlArray("commission_clause")]
		[XmlArrayItem("kb_advert_commission_clause")]
		public List<KbAdvertCommissionClause> CommissionClause
		{
			get;
			set;
		}

		[XmlElement("identify")]
		public string Identify
		{
			get;
			set;
		}

		[XmlElement("identify_type")]
		public string IdentifyType
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

		[XmlElement("operator_id")]
		public string OperatorId
		{
			get;
			set;
		}

		[XmlElement("operator_type")]
		public string OperatorType
		{
			get;
			set;
		}

		[XmlElement("smart_promo")]
		public KbadvertSmartPromoRequest SmartPromo
		{
			get;
			set;
		}
	}
}
