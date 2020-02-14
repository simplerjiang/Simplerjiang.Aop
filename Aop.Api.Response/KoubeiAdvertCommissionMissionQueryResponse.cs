using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiAdvertCommissionMissionQueryResponse : AopResponse
	{
		[XmlArray("data")]
		[XmlArrayItem("kb_advert_mission_query_response")]
		public List<KbAdvertMissionQueryResponse> Data
		{
			get;
			set;
		}

		[XmlElement("processing_data")]
		public KbAdvertProcessMissionResponse ProcessingData
		{
			get;
			set;
		}
	}
}
