using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiQualityTestCloudacptCheckresultSubmitResponse : AopResponse
	{
		[XmlElement("activity_id")]
		public string ActivityId
		{
			get;
			set;
		}

		[XmlElement("batch_id")]
		public string BatchId
		{
			get;
			set;
		}
	}
}
