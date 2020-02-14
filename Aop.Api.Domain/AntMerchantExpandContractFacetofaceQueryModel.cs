using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AntMerchantExpandContractFacetofaceQueryModel : AopObject
	{
		[XmlElement("order_no")]
		public string OrderNo
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}
	}
}
