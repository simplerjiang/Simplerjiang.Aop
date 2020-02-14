using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class SsdataDataserviceRiskDeviceidentityQueryResponse : AopResponse
	{
		[XmlElement("ato_score")]
		public string AtoScore
		{
			get;
			set;
		}

		[XmlElement("fake_score")]
		public string FakeScore
		{
			get;
			set;
		}

		[XmlElement("rub_score")]
		public string RubScore
		{
			get;
			set;
		}

		[XmlElement("umid")]
		public string Umid
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
