using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarCarmodelCreateResponse : AopResponse
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

		[XmlElement("model_id")]
		public string ModelId
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
