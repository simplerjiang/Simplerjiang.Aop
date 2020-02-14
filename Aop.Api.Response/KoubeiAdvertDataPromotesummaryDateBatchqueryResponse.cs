using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiAdvertDataPromotesummaryDateBatchqueryResponse : AopResponse
	{
		[XmlArray("data")]
		[XmlArrayItem("promote_date_model")]
		public List<PromoteDateModel> Data
		{
			get;
			set;
		}
	}
}
