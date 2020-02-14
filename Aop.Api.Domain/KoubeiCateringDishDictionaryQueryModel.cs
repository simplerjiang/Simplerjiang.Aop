using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringDishDictionaryQueryModel : AopObject
	{
		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("dictionary_id")]
		public string DictionaryId
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

		[XmlElement("merchant_id")]
		public string MerchantId
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
