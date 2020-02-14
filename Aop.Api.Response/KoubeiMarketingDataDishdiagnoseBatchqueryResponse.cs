using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataDishdiagnoseBatchqueryResponse : AopResponse
	{
		[XmlArray("item_diagnose_list")]
		[XmlArrayItem("item_diagnose_detail")]
		public List<ItemDiagnoseDetail> ItemDiagnoseList
		{
			get;
			set;
		}

		[XmlElement("total")]
		public long Total
		{
			get;
			set;
		}
	}
}
