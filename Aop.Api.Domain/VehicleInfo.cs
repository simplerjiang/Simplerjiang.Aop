using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class VehicleInfo : AopObject
	{
		[XmlElement("company_id")]
		public string CompanyId
		{
			get;
			set;
		}

		[XmlElement("vehicle_code")]
		public string VehicleCode
		{
			get;
			set;
		}
	}
}
