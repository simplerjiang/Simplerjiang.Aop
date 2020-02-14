using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsCooperationProductOfflineBatchqueryResponse : AopResponse
	{
		[XmlArray("product_list")]
		[XmlArrayItem("ins_offilne_product")]
		public List<InsOffilneProduct> ProductList
		{
			get;
			set;
		}
	}
}
