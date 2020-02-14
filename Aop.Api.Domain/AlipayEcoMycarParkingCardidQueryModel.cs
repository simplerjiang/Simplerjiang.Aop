using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarParkingCardidQueryModel : AopObject
	{
		[XmlElement("car_number")]
		public string CarNumber
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

		[XmlElement("sel_time")]
		public string SelTime
		{
			get;
			set;
		}

		[XmlElement("transaction_no")]
		public string TransactionNo
		{
			get;
			set;
		}
	}
}
