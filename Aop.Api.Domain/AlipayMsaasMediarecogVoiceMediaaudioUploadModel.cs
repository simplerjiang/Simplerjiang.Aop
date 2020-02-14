using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMsaasMediarecogVoiceMediaaudioUploadModel : AopObject
	{
		[XmlElement("data")]
		public string Data
		{
			get;
			set;
		}

		[XmlElement("extinfo_a")]
		public string ExtinfoA
		{
			get;
			set;
		}

		[XmlElement("extinfo_b")]
		public string ExtinfoB
		{
			get;
			set;
		}

		[XmlElement("extinfo_c")]
		public string ExtinfoC
		{
			get;
			set;
		}

		[XmlElement("extinfo_d")]
		public string ExtinfoD
		{
			get;
			set;
		}

		[XmlElement("labeltime")]
		public string Labeltime
		{
			get;
			set;
		}

		[XmlElement("vname")]
		public string Vname
		{
			get;
			set;
		}

		[XmlElement("vtype")]
		public string Vtype
		{
			get;
			set;
		}
	}
}
