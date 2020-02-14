using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoLogisticsExpressNonserviceQueryModel : AopObject
	{
		[XmlElement("logis_merch_code")]
		public string LogisMerchCode
		{
			get;
			set;
		}
	}
}
