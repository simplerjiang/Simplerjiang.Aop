using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOverseasTaxOrderQueryResponse : AopResponse
	{
		[XmlElement("identify_account_no")]
		public string IdentifyAccountNo
		{
			get;
			set;
		}

		[XmlElement("identify_account_type")]
		public string IdentifyAccountType
		{
			get;
			set;
		}

		[XmlElement("out_order_no")]
		public string OutOrderNo
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("success_time")]
		public string SuccessTime
		{
			get;
			set;
		}

		[XmlElement("tax_no")]
		public string TaxNo
		{
			get;
			set;
		}
	}
}
