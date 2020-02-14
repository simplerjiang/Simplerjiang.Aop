using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaMerchantBorrowEntityUploadModel : AopObject
	{
		[XmlElement("address_desc")]
		public string AddressDesc
		{
			get;
			set;
		}

		[XmlElement("can_borrow")]
		public string CanBorrow
		{
			get;
			set;
		}

		[XmlElement("can_borrow_cnt")]
		public string CanBorrowCnt
		{
			get;
			set;
		}

		[XmlElement("category_code")]
		public string CategoryCode
		{
			get;
			set;
		}

		[XmlElement("collect_rent")]
		public string CollectRent
		{
			get;
			set;
		}

		[XmlElement("contact_number")]
		public string ContactNumber
		{
			get;
			set;
		}

		[XmlElement("entity_code")]
		public string EntityCode
		{
			get;
			set;
		}

		[XmlElement("entity_name")]
		public string EntityName
		{
			get;
			set;
		}

		[XmlElement("latitude")]
		public string Latitude
		{
			get;
			set;
		}

		[XmlElement("longitude")]
		public string Longitude
		{
			get;
			set;
		}

		[XmlElement("office_hours_desc")]
		public string OfficeHoursDesc
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

		[XmlElement("rent_desc")]
		public string RentDesc
		{
			get;
			set;
		}

		[XmlElement("total_borrow_cnt")]
		public string TotalBorrowCnt
		{
			get;
			set;
		}

		[XmlElement("upload_time")]
		public string UploadTime
		{
			get;
			set;
		}
	}
}
