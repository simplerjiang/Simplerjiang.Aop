using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class SsdataDataserviceRiskAntiscalperQueryResponse : AopResponse
	{
		[XmlElement("infocode")]
		public string Infocode
		{
			get;
			set;
		}

		[XmlElement("score")]
		public string Score
		{
			get;
			set;
		}

		[XmlElement("unique_id")]
		public string UniqueId
		{
			get;
			set;
		}
	}
}
