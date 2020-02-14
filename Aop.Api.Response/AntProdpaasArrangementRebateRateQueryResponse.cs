using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AntProdpaasArrangementRebateRateQueryResponse : AopResponse
	{
		[XmlElement("category_1_id")]
		public string Category1Id
		{
			get;
			set;
		}

		[XmlElement("category_1_name")]
		public string Category1Name
		{
			get;
			set;
		}

		[XmlElement("gmt_end")]
		public string GmtEnd
		{
			get;
			set;
		}

		[XmlElement("gmt_start")]
		public string GmtStart
		{
			get;
			set;
		}

		[XmlElement("rate")]
		public string Rate
		{
			get;
			set;
		}
	}
}
