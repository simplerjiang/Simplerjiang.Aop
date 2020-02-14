using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCreditEpFreedepositOrderriskQueryResponse : AopResponse
	{
		[XmlElement("decision")]
		public string Decision
		{
			get;
			set;
		}

		[XmlElement("lease_order_no")]
		public string LeaseOrderNo
		{
			get;
			set;
		}

		[XmlElement("merchant_lease_order_no")]
		public string MerchantLeaseOrderNo
		{
			get;
			set;
		}

		[XmlElement("reject_reason")]
		public string RejectReason
		{
			get;
			set;
		}
	}
}
