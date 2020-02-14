using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MerchantBaseEnterOpenModel : AopObject
	{
		[XmlElement("logo_info")]
		public string LogoInfo
		{
			get;
			set;
		}

		[XmlElement("m_name")]
		public string MName
		{
			get;
			set;
		}

		[XmlElement("m_short_name")]
		public string MShortName
		{
			get;
			set;
		}
	}
}
