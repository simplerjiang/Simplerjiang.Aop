using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaDataFeedbackurlQueryModel : AopObject
	{
		[XmlElement("merchant_id")]
		public string MerchantId
		{
			get;
			set;
		}
	}
}
