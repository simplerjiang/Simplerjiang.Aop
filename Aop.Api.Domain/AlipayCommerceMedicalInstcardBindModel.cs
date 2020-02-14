using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceMedicalInstcardBindModel : AopObject
	{
		[XmlElement("city_code")]
		public string CityCode
		{
			get;
			set;
		}

		[XmlElement("extend_params")]
		public string ExtendParams
		{
			get;
			set;
		}

		[XmlElement("return_url")]
		public string ReturnUrl
		{
			get;
			set;
		}
	}
}
