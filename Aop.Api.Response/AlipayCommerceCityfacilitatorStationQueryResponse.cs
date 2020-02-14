using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceCityfacilitatorStationQueryResponse : AopResponse
	{
		[XmlArray("support_starts")]
		[XmlArrayItem("station_detail_info")]
		public List<StationDetailInfo> SupportStarts
		{
			get;
			set;
		}
	}
}
