using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingToolPointsQueryResponse : AopResponse
	{
		[XmlElement("available_points")]
		public string AvailablePoints
		{
			get;
			set;
		}

		[XmlElement("freezed_points")]
		public string FreezedPoints
		{
			get;
			set;
		}

		[XmlElement("total_points")]
		public string TotalPoints
		{
			get;
			set;
		}
	}
}
