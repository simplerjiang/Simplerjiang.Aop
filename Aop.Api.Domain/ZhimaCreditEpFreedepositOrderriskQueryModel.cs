using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaCreditEpFreedepositOrderriskQueryModel : AopObject
	{
		[XmlElement("current_use_limit")]
		public long CurrentUseLimit
		{
			get;
			set;
		}

		[XmlElement("ep_cert_no")]
		public string EpCertNo
		{
			get;
			set;
		}

		[XmlElement("ep_cert_type")]
		public string EpCertType
		{
			get;
			set;
		}

		[XmlElement("ep_name")]
		public string EpName
		{
			get;
			set;
		}

		[XmlElement("first_rent_amount")]
		public long FirstRentAmount
		{
			get;
			set;
		}

		[XmlElement("lease_periods")]
		public long LeasePeriods
		{
			get;
			set;
		}

		[XmlArray("machine_info_list")]
		[XmlArrayItem("machine_info")]
		public List<MachineInfo> MachineInfoList
		{
			get;
			set;
		}

		[XmlElement("merchant_lease_order_no")]
		public string MerchantLeaseOrderNo
		{
			get;
			set;
		}

		[XmlElement("need_pay_deposit_amount")]
		public long NeedPayDepositAmount
		{
			get;
			set;
		}

		[XmlElement("order_no")]
		public string OrderNo
		{
			get;
			set;
		}

		[XmlElement("pay_date")]
		public string PayDate
		{
			get;
			set;
		}

		[XmlElement("period_lease_amount")]
		public long PeriodLeaseAmount
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

		[XmlElement("rec_address")]
		public string RecAddress
		{
			get;
			set;
		}

		[XmlElement("rec_mobile")]
		public string RecMobile
		{
			get;
			set;
		}

		[XmlElement("rec_name")]
		public string RecName
		{
			get;
			set;
		}

		[XmlElement("remain_limit")]
		public long RemainLimit
		{
			get;
			set;
		}

		[XmlElement("total_amount")]
		public long TotalAmount
		{
			get;
			set;
		}
	}
}
