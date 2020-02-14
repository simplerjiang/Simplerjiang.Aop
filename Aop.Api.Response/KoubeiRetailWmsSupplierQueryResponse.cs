using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailWmsSupplierQueryResponse : AopResponse
	{
		[XmlArray("suppliers")]
		[XmlArrayItem("supplier_v_o")]
		public List<SupplierVO> Suppliers
		{
			get;
			set;
		}

		[XmlElement("total_count")]
		public long TotalCount
		{
			get;
			set;
		}
	}
}
