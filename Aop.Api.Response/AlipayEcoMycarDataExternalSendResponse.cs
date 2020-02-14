using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarDataExternalSendResponse : AopResponse
	{
		[XmlElement("external_system_name")]
		public string ExternalSystemName
		{
			get;
			set;
		}

		[XmlElement("process_result")]
		public string ProcessResult
		{
			get;
			set;
		}
	}
}
