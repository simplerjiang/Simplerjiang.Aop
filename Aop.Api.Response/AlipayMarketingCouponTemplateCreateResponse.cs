using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCouponTemplateCreateResponse : AopResponse
	{
		[XmlElement("confirm_uri")]
		public string ConfirmUri
		{
			get;
			set;
		}

		[XmlElement("fund_order_no")]
		public string FundOrderNo
		{
			get;
			set;
		}

		[XmlElement("template_id")]
		public string TemplateId
		{
			get;
			set;
		}
	}
}
