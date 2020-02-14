using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingDataSmartactivityForecastModel : AopObject
	{
		[XmlElement("config_code")]
		public string ConfigCode
		{
			get;
			set;
		}

		[XmlElement("diagnose_code")]
		public string DiagnoseCode
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}
	}
}
