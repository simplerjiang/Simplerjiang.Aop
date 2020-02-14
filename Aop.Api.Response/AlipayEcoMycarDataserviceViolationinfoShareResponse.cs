using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarDataserviceViolationinfoShareResponse : AopResponse
	{
		[XmlElement("body_num")]
		public string BodyNum
		{
			get;
			set;
		}

		[XmlElement("engine_num")]
		public string EngineNum
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

		[XmlElement("vi_number")]
		public string ViNumber
		{
			get;
			set;
		}
	}
}
