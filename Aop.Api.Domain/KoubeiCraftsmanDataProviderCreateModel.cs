using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCraftsmanDataProviderCreateModel : AopObject
	{
		[XmlElement("account")]
		public string Account
		{
			get;
			set;
		}

		[XmlElement("auth_code")]
		public string AuthCode
		{
			get;
			set;
		}

		[XmlElement("avatar")]
		public string Avatar
		{
			get;
			set;
		}

		[XmlElement("career_begin")]
		public string CareerBegin
		{
			get;
			set;
		}

		[XmlArray("careers")]
		[XmlArrayItem("string")]
		public List<string> Careers
		{
			get;
			set;
		}

		[XmlElement("introduction")]
		public string Introduction
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

		[XmlElement("nick_name")]
		public string NickName
		{
			get;
			set;
		}

		[XmlElement("out_craftsman_id")]
		public string OutCraftsmanId
		{
			get;
			set;
		}

		[XmlArray("shop_relations")]
		[XmlArrayItem("craftsman_shop_relation_open_model")]
		public List<CraftsmanShopRelationOpenModel> ShopRelations
		{
			get;
			set;
		}

		[XmlArray("specialities")]
		[XmlArrayItem("string")]
		public List<string> Specialities
		{
			get;
			set;
		}

		[XmlElement("tel_num")]
		public string TelNum
		{
			get;
			set;
		}

		[XmlElement("title")]
		public string Title
		{
			get;
			set;
		}
	}
}
