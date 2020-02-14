using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ItermInfo : AopObject
	{
		[XmlElement("error_message")]
		public string ErrorMessage
		{
			get;
			set;
		}

		[XmlElement("is_for_sale")]
		public string IsForSale
		{
			get;
			set;
		}

		[XmlElement("item_code")]
		public string ItemCode
		{
			get;
			set;
		}

		[XmlElement("mark_price")]
		public string MarkPrice
		{
			get;
			set;
		}

		[XmlElement("success")]
		public bool Success
		{
			get;
			set;
		}

		[XmlElement("supplier_price")]
		public string SupplierPrice
		{
			get;
			set;
		}
	}
}
