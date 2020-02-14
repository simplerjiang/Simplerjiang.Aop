using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailWmsSupplierQueryModel : AopObject
	{
		[XmlElement("operate_context")]
		public OperateContext OperateContext
		{
			get;
			set;
		}

		[XmlArray("supplier_ids")]
		[XmlArrayItem("string")]
		public List<string> SupplierIds
		{
			get;
			set;
		}
	}
}
