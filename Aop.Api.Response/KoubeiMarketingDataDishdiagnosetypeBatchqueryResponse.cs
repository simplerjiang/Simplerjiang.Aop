using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataDishdiagnosetypeBatchqueryResponse : AopResponse
	{
		[XmlArray("item_diagnose_type_list")]
		[XmlArrayItem("item_diagnose_type")]
		public List<ItemDiagnoseType> ItemDiagnoseTypeList
		{
			get;
			set;
		}
	}
}
