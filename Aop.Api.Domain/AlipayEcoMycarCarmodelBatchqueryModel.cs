using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarCarmodelBatchqueryModel : AopObject
	{
		[XmlElement("brand_id")]
		public string BrandId
		{
			get;
			set;
		}

		[XmlElement("company_id")]
		public string CompanyId
		{
			get;
			set;
		}

		[XmlElement("query_type")]
		public string QueryType
		{
			get;
			set;
		}

		[XmlElement("serie_id")]
		public string SerieId
		{
			get;
			set;
		}
	}
}
