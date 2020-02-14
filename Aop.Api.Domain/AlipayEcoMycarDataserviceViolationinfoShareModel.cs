using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarDataserviceViolationinfoShareModel : AopObject
	{
		[XmlElement("app_id")]
		public string AppId
		{
			get;
			set;
		}

		[XmlElement("vehicle_id")]
		public string VehicleId
		{
			get;
			set;
		}
	}
}
