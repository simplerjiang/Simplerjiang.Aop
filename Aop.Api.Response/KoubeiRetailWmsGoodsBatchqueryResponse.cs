using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailWmsGoodsBatchqueryResponse : AopResponse
	{
		[XmlArray("goods")]
		[XmlArrayItem("goods_v_o")]
		public List<GoodsVO> Goods
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
