using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiAdvertCommissionMissionSearchResponse : AopResponse
	{
		[XmlArray("data")]
		[XmlArrayItem("kb_advert_mission_response")]
		public List<KbAdvertMissionResponse> Data
		{
			get;
			set;
		}

		[XmlElement("page_index")]
		public long PageIndex
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public long PageSize
		{
			get;
			set;
		}

		[XmlElement("total_count")]
		public long TotalCount
		{
			get;
			set;
		}
	}
}
