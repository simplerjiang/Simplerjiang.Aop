using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class OutboundOrder : AopObject
	{
		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("outbound_type")]
		public string OutboundType
		{
			get;
			set;
		}

		[XmlElement("receiver_info_vo")]
		public ReceiverInfoVO ReceiverInfoVo
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

		[XmlElement("sender_info_vo")]
		public SenderInfoVO SenderInfoVo
		{
			get;
			set;
		}

		[XmlElement("warehouse_code")]
		public string WarehouseCode
		{
			get;
			set;
		}
	}
}
