using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SsdataDataserviceDtevalIdentitycheckQueryModel : AopObject
	{
		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("col_cert_no")]
		public string ColCertNo
		{
			get;
			set;
		}

		[XmlElement("col_mobile")]
		public string ColMobile
		{
			get;
			set;
		}

		[XmlElement("col_user_name")]
		public string ColUserName
		{
			get;
			set;
		}

		[XmlElement("ext_map")]
		public string ExtMap
		{
			get;
			set;
		}

		[XmlElement("real_cert_no")]
		public string RealCertNo
		{
			get;
			set;
		}

		[XmlElement("real_mobile")]
		public string RealMobile
		{
			get;
			set;
		}

		[XmlElement("real_user_name")]
		public string RealUserName
		{
			get;
			set;
		}
	}
}
