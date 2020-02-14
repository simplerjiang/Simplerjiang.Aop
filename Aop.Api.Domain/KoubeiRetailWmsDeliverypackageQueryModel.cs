using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailWmsDeliverypackageQueryModel : AopObject
	{
		[XmlElement("express_code")]
		public string ExpressCode
		{
			get;
			set;
		}

		[XmlElement("notice_order_id")]
		public string NoticeOrderId
		{
			get;
			set;
		}

		[XmlElement("operate_context")]
		public OperateContext OperateContext
		{
			get;
			set;
		}

		[XmlElement("work_order_id")]
		public string WorkOrderId
		{
			get;
			set;
		}
	}
}
