using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MaintainOrderStatusExtParams : AopObject
	{
		[XmlElement("logistics_code")]
		public string LogisticsCode
		{
			get;
			set;
		}

		[XmlElement("logistics_company")]
		public string LogisticsCompany
		{
			get;
			set;
		}

		[XmlElement("logistics_no")]
		public string LogisticsNo
		{
			get;
			set;
		}

		[XmlElement("order_status_txt")]
		public string OrderStatusTxt
		{
			get;
			set;
		}

		[XmlElement("receiver_addr")]
		public string ReceiverAddr
		{
			get;
			set;
		}

		[XmlElement("sender_addr")]
		public string SenderAddr
		{
			get;
			set;
		}
	}
}
