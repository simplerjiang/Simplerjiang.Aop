using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoLogisticsExpressPriceQueryModel : AopObject
	{
		[XmlElement("area_type")]
		public string AreaType
		{
			get;
			set;
		}

		[XmlElement("from_code")]
		public string FromCode
		{
			get;
			set;
		}

		[XmlElement("logis_merch_code")]
		public string LogisMerchCode
		{
			get;
			set;
		}

		[XmlElement("product_type_code")]
		public string ProductTypeCode
		{
			get;
			set;
		}

		[XmlElement("to_code")]
		public string ToCode
		{
			get;
			set;
		}
	}
}
