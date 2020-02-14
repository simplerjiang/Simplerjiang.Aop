using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertMissionSubject : AopObject
	{
		[XmlArray("commission_clause_list")]
		[XmlArrayItem("kb_advert_commission_clause")]
		public List<KbAdvertCommissionClause> CommissionClauseList
		{
			get;
			set;
		}

		[XmlElement("subject_biz_id")]
		public string SubjectBizId
		{
			get;
			set;
		}

		[XmlElement("subject_type")]
		public string SubjectType
		{
			get;
			set;
		}
	}
}
