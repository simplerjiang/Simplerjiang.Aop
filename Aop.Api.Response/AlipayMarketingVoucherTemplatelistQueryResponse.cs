using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingVoucherTemplatelistQueryResponse : AopResponse
	{
		[XmlElement("current_page")]
		public long CurrentPage
		{
			get;
			set;
		}

		[XmlElement("items_per_page")]
		public long ItemsPerPage
		{
			get;
			set;
		}

		[XmlElement("total_items")]
		public long TotalItems
		{
			get;
			set;
		}

		[XmlElement("total_pages")]
		public long TotalPages
		{
			get;
			set;
		}

		[XmlArray("voucher_templates")]
		[XmlArrayItem("voucher_template_lite_info")]
		public List<VoucherTemplateLiteInfo> VoucherTemplates
		{
			get;
			set;
		}
	}
}
