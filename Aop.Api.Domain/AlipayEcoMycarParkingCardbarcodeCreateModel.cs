using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarParkingCardbarcodeCreateModel : AopObject
	{
		[XmlElement("equipment_id")]
		public string EquipmentId
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
	}
}
