using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class SsdataDataserviceRiskDigitalidentityQueryResponse : AopResponse
	{
		[XmlElement("ato_score")]
		public string AtoScore
		{
			get;
			set;
		}

		[XmlElement("deviceid")]
		public string Deviceid
		{
			get;
			set;
		}

		[XmlElement("emulator")]
		public bool Emulator
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

		[XmlElement("root")]
		public bool Root
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

		[XmlElement("unique_id")]
		public string UniqueId
		{
			get;
			set;
		}
	}
}
