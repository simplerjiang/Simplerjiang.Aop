using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsMarketingCertificateBatchcreateModel : AopObject
	{
		[XmlArray("ins_create_certificate_requests")]
		[XmlArrayItem("ins_create_certificate_request")]
		public List<InsCreateCertificateRequest> InsCreateCertificateRequests
		{
			get;
			set;
		}
	}
}
