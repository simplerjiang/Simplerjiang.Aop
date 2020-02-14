using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AntProdpaasArrangementCommonQueryModel : AopObject
	{
		[XmlElement("arrangement_base_selector")]
		public ArrangementBaseSelector ArrangementBaseSelector
		{
			get;
			set;
		}

		[XmlElement("arrangement_condition_group_selector")]
		public ArrangementConditionGroupSelector ArrangementConditionGroupSelector
		{
			get;
			set;
		}

		[XmlElement("arrangement_involved_party_querier")]
		public ArrangementInvolvedPartyQuerier ArrangementInvolvedPartyQuerier
		{
			get;
			set;
		}

		[XmlElement("arrangement_no_querier")]
		public ArrangementNoQuerier ArrangementNoQuerier
		{
			get;
			set;
		}
	}
}
