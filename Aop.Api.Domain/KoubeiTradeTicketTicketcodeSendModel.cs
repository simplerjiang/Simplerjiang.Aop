using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiTradeTicketTicketcodeSendModel : AopObject
	{
		[XmlArray("isv_ma_list")]
		[XmlArrayItem("kb_isv_ma_code")]
		public List<KbIsvMaCode> IsvMaList
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

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}

		[XmlElement("send_order_no")]
		public string SendOrderNo
		{
			get;
			set;
		}

		[XmlElement("send_token")]
		public string SendToken
		{
			get;
			set;
		}
	}
}
