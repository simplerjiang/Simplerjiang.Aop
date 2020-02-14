using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SubMerchantCommonEnterOpenModel : AopObject
	{
		[XmlElement("extend_fields")]
		public string ExtendFields
		{
			get;
			set;
		}

		[XmlElement("product_code")]
		public string ProductCode
		{
			get;
			set;
		}

		[XmlElement("s_short_name")]
		public string SShortName
		{
			get;
			set;
		}
	}
}
