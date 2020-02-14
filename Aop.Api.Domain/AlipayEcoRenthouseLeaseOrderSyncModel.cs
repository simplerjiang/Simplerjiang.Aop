using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoRenthouseLeaseOrderSyncModel : AopObject
	{
		[XmlElement("attach_file")]
		public string AttachFile
		{
			get;
			set;
		}

		[XmlElement("begin_date")]
		public string BeginDate
		{
			get;
			set;
		}

		[XmlElement("book_info")]
		public AlipayEcoRenthouseBookInfo BookInfo
		{
			get;
			set;
		}

		[XmlElement("card_no")]
		public string CardNo
		{
			get;
			set;
		}

		[XmlElement("card_type")]
		public long CardType
		{
			get;
			set;
		}

		[XmlElement("end_date")]
		public string EndDate
		{
			get;
			set;
		}

		[XmlElement("flats_tag")]
		public long FlatsTag
		{
			get;
			set;
		}

		[XmlElement("foregift_amount")]
		public string ForegiftAmount
		{
			get;
			set;
		}

		[XmlElement("free_deposit")]
		public long FreeDeposit
		{
			get;
			set;
		}

		[XmlElement("furniture_items")]
		public string FurnitureItems
		{
			get;
			set;
		}

		[XmlElement("images")]
		public string Images
		{
			get;
			set;
		}

		[XmlElement("lease_code")]
		public string LeaseCode
		{
			get;
			set;
		}

		[XmlElement("lease_create_time")]
		public string LeaseCreateTime
		{
			get;
			set;
		}

		[XmlElement("lease_status")]
		public long LeaseStatus
		{
			get;
			set;
		}

		[XmlElement("lease_type")]
		public long LeaseType
		{
			get;
			set;
		}

		[XmlElement("original_lease_code")]
		public string OriginalLeaseCode
		{
			get;
			set;
		}

		[XmlElement("other_fee_desc")]
		public string OtherFeeDesc
		{
			get;
			set;
		}

		[XmlElement("pay_type")]
		public long PayType
		{
			get;
			set;
		}

		[XmlElement("rebate_amount")]
		public string RebateAmount
		{
			get;
			set;
		}

		[XmlElement("remark")]
		public string Remark
		{
			get;
			set;
		}

		[XmlElement("renew_lease")]
		public long RenewLease
		{
			get;
			set;
		}

		[XmlElement("renew_num")]
		public long RenewNum
		{
			get;
			set;
		}

		[XmlElement("rent_day_desc")]
		public string RentDayDesc
		{
			get;
			set;
		}

		[XmlArray("rent_include_fee_desc")]
		[XmlArrayItem("string")]
		public List<string> RentIncludeFeeDesc
		{
			get;
			set;
		}

		[XmlElement("renter_gender")]
		public string RenterGender
		{
			get;
			set;
		}

		[XmlElement("renter_name")]
		public string RenterName
		{
			get;
			set;
		}

		[XmlElement("renter_phone")]
		public string RenterPhone
		{
			get;
			set;
		}

		[XmlElement("room_code")]
		public string RoomCode
		{
			get;
			set;
		}

		[XmlElement("room_num")]
		public string RoomNum
		{
			get;
			set;
		}

		[XmlElement("sale_amount")]
		public string SaleAmount
		{
			get;
			set;
		}
	}
}
