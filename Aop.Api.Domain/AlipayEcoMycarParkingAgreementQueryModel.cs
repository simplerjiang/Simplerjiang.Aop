using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarParkingAgreementQueryModel : AopObject
	{
		[XmlElement("car_number")]
		public string CarNumber
		{
			get;
			set;
		}
	}
}
