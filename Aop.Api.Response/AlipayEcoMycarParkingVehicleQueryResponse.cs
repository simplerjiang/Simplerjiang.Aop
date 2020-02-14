using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarParkingVehicleQueryResponse : AopResponse
	{
		[XmlElement("car_number")]
		public string CarNumber
		{
			get;
			set;
		}
	}
}
