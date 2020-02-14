using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarViolationVehicleQueryResponse : AopResponse
	{
		[XmlElement("engine_no")]
		public string EngineNo
		{
			get;
			set;
		}

		[XmlElement("vi_id")]
		public string ViId
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

		[XmlElement("vin_no")]
		public string VinNo
		{
			get;
			set;
		}
	}
}
