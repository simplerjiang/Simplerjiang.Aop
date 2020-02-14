using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserStepcounterQueryResponse : AopResponse
	{
		[XmlElement("count")]
		public long Count
		{
			get;
			set;
		}

		[XmlElement("count_date")]
		public string CountDate
		{
			get;
			set;
		}

		[XmlElement("time_zone")]
		public string TimeZone
		{
			get;
			set;
		}
	}
}
