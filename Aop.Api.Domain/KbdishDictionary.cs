using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbdishDictionary : AopObject
	{
		[XmlElement("create_user")]
		public string CreateUser
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

		[XmlElement("name")]
		public string Name
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

		[XmlElement("update_user")]
		public string UpdateUser
		{
			get;
			set;
		}
	}
}
