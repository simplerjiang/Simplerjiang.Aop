using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMsaasMediarecogAftsCarIdentifyResponse : AopResponse
	{
		[XmlElement("cheat_probability")]
		public long CheatProbability
		{
			get;
			set;
		}

		[XmlElement("cheat_type")]
		public string CheatType
		{
			get;
			set;
		}

		[XmlElement("ocr_kilometres")]
		public long OcrKilometres
		{
			get;
			set;
		}

		[XmlElement("ocr_probability")]
		public long OcrProbability
		{
			get;
			set;
		}
	}
}
