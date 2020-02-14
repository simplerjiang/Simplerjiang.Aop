using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayDataDataserviceHolographicFactorQueryModel : AopObject
	{
		[XmlElement("biz_id")]
		public string BizId
		{
			get;
			set;
		}

		[XmlElement("cert_no")]
		public string CertNo
		{
			get;
			set;
		}

		[XmlArray("contact_info_list")]
		[XmlArrayItem("holo_graphic_contact_info")]
		public List<HoloGraphicContactInfo> ContactInfoList
		{
			get;
			set;
		}

		[XmlElement("isv_feature")]
		public string IsvFeature
		{
			get;
			set;
		}

		[XmlElement("mobile")]
		public string Mobile
		{
			get;
			set;
		}

		[XmlElement("user_name")]
		public string UserName
		{
			get;
			set;
		}
	}
}
