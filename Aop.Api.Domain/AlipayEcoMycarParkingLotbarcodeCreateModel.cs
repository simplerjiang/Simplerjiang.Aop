using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarParkingLotbarcodeCreateModel : AopObject
	{
		[XmlElement("parking_id")]
		public string ParkingId
		{
			get;
			set;
		}
	}
}
