using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CascadeMissionConfModel : AopObject
	{
		[XmlArray("commission_clause")]
		[XmlArrayItem("kb_advert_commission_clause")]
		public List<KbAdvertCommissionClause> CommissionClause
		{
			get;
			set;
		}

		[XmlElement("commission_user_type")]
		public string CommissionUserType
		{
			get;
			set;
		}
	}
}
