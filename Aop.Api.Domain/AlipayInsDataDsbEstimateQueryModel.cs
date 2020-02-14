using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsDataDsbEstimateQueryModel : AopObject
	{
		[XmlElement("estimate_no")]
		public string EstimateNo
		{
			get;
			set;
		}

		[XmlElement("frame_no")]
		public string FrameNo
		{
			get;
			set;
		}

		[XmlElement("license_no")]
		public string LicenseNo
		{
			get;
			set;
		}
	}
}
