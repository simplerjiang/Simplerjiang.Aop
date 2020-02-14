using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FundDetailItemAOPModel : AopObject
	{
		[XmlArray("single_fund_detail_item_aopmodel_list")]
		[XmlArrayItem("single_fund_detail_item_a_o_p_model")]
		public List<SingleFundDetailItemAOPModel> SingleFundDetailItemAopmodelList
		{
			get;
			set;
		}
	}
}
