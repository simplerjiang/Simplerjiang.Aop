using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarMaintainOrderstatusUpdateModel : AopObject
	{
		[XmlElement("ext_param")]
		public MaintainOrderStatusExtParams ExtParam
		{
			get;
			set;
		}

		[XmlElement("industry_code")]
		public string IndustryCode
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

		[XmlElement("order_status")]
		public string OrderStatus
		{
			get;
			set;
		}

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}
	}
}
