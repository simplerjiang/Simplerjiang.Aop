using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiAdvertCommissionAdvchannelBatchqueryModel : AopObject
	{
		[XmlElement("adv_id")]
		public string AdvId
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
	}
}
