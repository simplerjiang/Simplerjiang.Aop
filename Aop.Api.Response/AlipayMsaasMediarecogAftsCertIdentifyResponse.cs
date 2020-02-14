using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMsaasMediarecogAftsCertIdentifyResponse : AopResponse
	{
		[XmlElement("cert_probability")]
		public long CertProbability
		{
			get;
			set;
		}

		[XmlElement("cert_type")]
		public string CertType
		{
			get;
			set;
		}

		[XmlElement("ocr_engine_number")]
		public string OcrEngineNumber
		{
			get;
			set;
		}

		[XmlElement("ocr_name")]
		public string OcrName
		{
			get;
			set;
		}

		[XmlElement("ocr_plate_number")]
		public string OcrPlateNumber
		{
			get;
			set;
		}

		[XmlElement("ocr_vehicle_id")]
		public string OcrVehicleId
		{
			get;
			set;
		}
	}
}
