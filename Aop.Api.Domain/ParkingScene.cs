using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ParkingScene : AopObject
	{
		[XmlElement("car_number")]
		public string CarNumber
		{
			get;
			set;
		}

		[XmlElement("in_time")]
		public string InTime
		{
			get;
			set;
		}

		[XmlElement("parking_id")]
		public string ParkingId
		{
			get;
			set;
		}

		[XmlElement("parking_name")]
		public string ParkingName
		{
			get;
			set;
		}
	}
}
