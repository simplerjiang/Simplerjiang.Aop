using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMerchantDepartmentShopModifyModel : AopObject
	{
		[XmlElement("auth_code")]
		public string AuthCode
		{
			get;
			set;
		}

		[XmlElement("dept_id")]
		public string DeptId
		{
			get;
			set;
		}

		[XmlElement("dept_type")]
		public string DeptType
		{
			get;
			set;
		}

		[XmlArray("shop_list_to_add")]
		[XmlArrayItem("simple_shop_model")]
		public List<SimpleShopModel> ShopListToAdd
		{
			get;
			set;
		}

		[XmlArray("shop_list_to_remove")]
		[XmlArrayItem("simple_shop_model")]
		public List<SimpleShopModel> ShopListToRemove
		{
			get;
			set;
		}
	}
}
