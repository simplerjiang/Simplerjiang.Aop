using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarParkingParkinglotinfoCreateResponse : AopResponse
	{
		[XmlElement("parking_id")]
		public string ParkingId
		{
			get;
			set;
		}
	}
}
