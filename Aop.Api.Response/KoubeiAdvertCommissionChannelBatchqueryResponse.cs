using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiAdvertCommissionChannelBatchqueryResponse : AopResponse
	{
		[XmlElement("data")]
		public KbAdvertChannelResponse Data
		{
			get;
			set;
		}

		[XmlElement("page_index")]
		public string PageIndex
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public string PageSize
		{
			get;
			set;
		}

		[XmlElement("total_count")]
		public string TotalCount
		{
			get;
			set;
		}
	}
}
