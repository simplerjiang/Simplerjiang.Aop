using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PosOrderInfoVO : AopObject
	{
		[XmlElement("device_amount")]
		public long DeviceAmount
		{
			get;
			set;
		}

		[XmlElement("isv_name")]
		public string IsvName
		{
			get;
			set;
		}

		[XmlElement("isv_pid")]
		public string IsvPid
		{
			get;
			set;
		}

		[XmlArray("machine_infos")]
		[XmlArrayItem("pos_order_device_info_v_o")]
		public List<PosOrderDeviceInfoVO> MachineInfos
		{
			get;
			set;
		}

		[XmlElement("merchant_mobile")]
		public string MerchantMobile
		{
			get;
			set;
		}

		[XmlElement("merchant_name")]
		public string MerchantName
		{
			get;
			set;
		}

		[XmlElement("order_amt")]
		public string OrderAmt
		{
			get;
			set;
		}

		[XmlElement("order_channel")]
		public string OrderChannel
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

		[XmlElement("seller_id")]
		public string SellerId
		{
			get;
			set;
		}

		[XmlElement("seller_name")]
		public string SellerName
		{
			get;
			set;
		}

		[XmlElement("taobao_login_id")]
		public string TaobaoLoginId
		{
			get;
			set;
		}
	}
}
