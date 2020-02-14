using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailWmsPartnerQueryResponse : AopResponse
	{
		[XmlArray("partners")]
		[XmlArrayItem("partner_v_o")]
		public List<PartnerVO> Partners
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
