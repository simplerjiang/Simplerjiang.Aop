using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCampaignSubcertQueryResponse : AopResponse
	{
		[XmlArray("subcert_list")]
		[XmlArrayItem("sub_cert_detail")]
		public List<SubCertDetail> SubcertList
		{
			get;
			set;
		}

		[XmlElement("total_num")]
		public string TotalNum
		{
			get;
			set;
		}
	}
}
