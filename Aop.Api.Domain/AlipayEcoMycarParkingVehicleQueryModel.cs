using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarParkingVehicleQueryModel : AopObject
	{
		[XmlElement("car_id")]
		public string CarId
		{
			get;
			set;
		}
	}
}
