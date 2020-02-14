using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingDataSmartactivityConfigModel : AopObject
	{
		[XmlElement("diagnose_code")]
		public string DiagnoseCode
		{
			get;
			set;
		}
	}
}
