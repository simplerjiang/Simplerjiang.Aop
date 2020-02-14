using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingToolIsvMerchantQueryModel : AopObject
	{
		[XmlElement("page_num")]
		public string PageNum
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public string PageSize
		{
			get;
			set;
		}
	}
}
