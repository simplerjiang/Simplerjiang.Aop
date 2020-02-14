using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiAdvertCommissionMissionCreateResponse : AopResponse
	{
		[XmlElement("mission_id")]
		public string MissionId
		{
			get;
			set;
		}
	}
}
