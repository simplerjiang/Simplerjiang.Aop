using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicAdvertBatchqueryResponse : AopResponse
	{
		[XmlArray("advert_list")]
		[XmlArrayItem("advert")]
		public List<Advert> AdvertList
		{
			get;
			set;
		}
	}
}
