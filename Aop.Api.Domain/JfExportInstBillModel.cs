using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class JfExportInstBillModel : AopObject
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("balance")]
		public string Balance
		{
			get;
			set;
		}

		[XmlElement("bill_date")]
		public string BillDate
		{
			get;
			set;
		}

		[XmlElement("bill_fines")]
		public string BillFines
		{
			get;
			set;
		}

		[XmlElement("bill_key")]
		public string BillKey
		{
			get;
			set;
		}

		[XmlElement("extend_field")]
		public string ExtendField
		{
			get;
			set;
		}

		[XmlElement("inst_bill_no")]
		public string InstBillNo
		{
			get;
			set;
		}

		[XmlElement("owner_name")]
		public string OwnerName
		{
			get;
			set;
		}

		[XmlElement("uniq_id")]
		public string UniqId
		{
			get;
			set;
		}
	}
}
