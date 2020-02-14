using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ParkingOutScene : AopObject
	{
		[XmlElement("car_number")]
		public string CarNumber
		{
			get;
			set;
		}

		[XmlElement("fee")]
		public string Fee
		{
			get;
			set;
		}

		[XmlElement("out_time")]
		public string OutTime
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
