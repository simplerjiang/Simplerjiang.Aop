using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailWmsGoodsBatchqueryModel : AopObject
	{
		[XmlArray("goods_codes")]
		[XmlArrayItem("string")]
		public List<string> GoodsCodes
		{
			get;
			set;
		}
	}
}
