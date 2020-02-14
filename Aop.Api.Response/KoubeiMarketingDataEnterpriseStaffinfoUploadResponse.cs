using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataEnterpriseStaffinfoUploadResponse : AopResponse
	{
		[XmlElement("crowd_id")]
		public string CrowdId
		{
			get;
			set;
		}
	}
}
