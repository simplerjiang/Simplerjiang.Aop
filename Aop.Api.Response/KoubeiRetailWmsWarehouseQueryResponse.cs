using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailWmsWarehouseQueryResponse : AopResponse
	{
		[XmlElement("total_count")]
		public long TotalCount
		{
			get;
			set;
		}

		[XmlArray("warehouses")]
		[XmlArrayItem("warehouse_v_o")]
		public List<WarehouseVO> Warehouses
		{
			get;
			set;
		}
	}
}
