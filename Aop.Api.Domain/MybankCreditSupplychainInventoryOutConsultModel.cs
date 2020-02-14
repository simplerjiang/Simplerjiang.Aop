using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditSupplychainInventoryOutConsultModel : AopObject
	{
		[XmlElement("ar_no")]
		public string ArNo
		{
			get;
			set;
		}

		[XmlArray("asset_info_list")]
		[XmlArrayItem("inventory_info")]
		public List<InventoryInfo> AssetInfoList
		{
			get;
			set;
		}

		[XmlElement("customer")]
		public Member Customer
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

		[XmlElement("out_order_no")]
		public string OutOrderNo
		{
			get;
			set;
		}

		[XmlElement("sale_pd_code")]
		public string SalePdCode
		{
			get;
			set;
		}

		[XmlElement("trade_type")]
		public string TradeType
		{
			get;
			set;
		}
	}
}
