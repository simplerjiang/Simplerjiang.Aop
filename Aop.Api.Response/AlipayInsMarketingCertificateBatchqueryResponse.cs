using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsMarketingCertificateBatchqueryResponse : AopResponse
	{
		[XmlElement("ins_certificate_pagination_list")]
		public InsCertificatePaginationList InsCertificatePaginationList
		{
			get;
			set;
		}
	}
}
