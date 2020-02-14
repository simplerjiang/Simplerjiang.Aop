using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingSharetokenDecodeModel : AopObject
	{
		[XmlElement("code_type")]
		public string CodeType
		{
			get;
			set;
		}

		[XmlElement("ext_data")]
		public string ExtData
		{
			get;
			set;
		}

		[XmlElement("token")]
		public string Token
		{
			get;
			set;
		}
	}
}
