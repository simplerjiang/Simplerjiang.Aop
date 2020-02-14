using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PromoItemInfo : AopObject
	{
		[XmlElement("constraint_info")]
		public ConstraintInfo ConstraintInfo
		{
			get;
			set;
		}

		[XmlElement("id")]
		public string Id
		{
			get;
			set;
		}

		[XmlElement("sale_end_time")]
		public string SaleEndTime
		{
			get;
			set;
		}

		[XmlElement("sale_start_time")]
		public string SaleStartTime
		{
			get;
			set;
		}

		[XmlElement("total_inventory")]
		public string TotalInventory
		{
			get;
			set;
		}

		[XmlElement("voucher")]
		public Voucher Voucher
		{
			get;
			set;
		}
	}
}
