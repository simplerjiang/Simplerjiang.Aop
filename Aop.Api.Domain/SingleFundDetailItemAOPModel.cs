using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SingleFundDetailItemAOPModel : AopObject
	{
		[XmlArray("batch_fund_item_model_list")]
		[XmlArrayItem("batch_fund_item_a_o_p_model")]
		public List<BatchFundItemAOPModel> BatchFundItemModelList
		{
			get;
			set;
		}

		[XmlElement("consume_record")]
		public ConsumeRecordAOPModel ConsumeRecord
		{
			get;
			set;
		}
	}
}
