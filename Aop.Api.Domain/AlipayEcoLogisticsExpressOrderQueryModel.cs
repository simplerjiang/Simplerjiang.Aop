using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoLogisticsExpressOrderQueryModel : AopObject
	{
		[XmlElement("logis_merch_code")]
		public string LogisMerchCode
		{
			get;
			set;
		}

		[XmlElement("order_no")]
		public string OrderNo
		{
			get;
			set;
		}
	}
}
