using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiAdvertCommissionMissionPromoteResponse : AopResponse
	{
		[XmlElement("advert")]
		public KbAdvertAdvResponse Advert
		{
			get;
			set;
		}

		[XmlElement("can_cascade_mission")]
		public string CanCascadeMission
		{
			get;
			set;
		}
	}
}
