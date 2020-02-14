using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCraftsmanDataWorkCreateModel : AopObject
	{
		[XmlElement("auth_code")]
		public string AuthCode
		{
			get;
			set;
		}

		[XmlElement("craftsman_id")]
		public string CraftsmanId
		{
			get;
			set;
		}

		[XmlArray("shop_ids")]
		[XmlArrayItem("string")]
		public List<string> ShopIds
		{
			get;
			set;
		}

		[XmlArray("works")]
		[XmlArrayItem("craftsman_work_create_open_model")]
		public List<CraftsmanWorkCreateOpenModel> Works
		{
			get;
			set;
		}
	}
}
