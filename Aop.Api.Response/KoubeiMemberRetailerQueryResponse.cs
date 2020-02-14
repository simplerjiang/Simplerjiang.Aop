using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMemberRetailerQueryResponse : AopResponse
	{
		[XmlArray("retailer_list")]
		[XmlArrayItem("retailer")]
		public List<Retailer> RetailerList
		{
			get;
			set;
		}
	}
}
