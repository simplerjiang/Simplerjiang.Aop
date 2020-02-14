using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarMaintainOrderserverNotifyModel : AopObject
	{
		[XmlElement("change_cost")]
		public string ChangeCost
		{
			get;
			set;
		}

		[XmlElement("change_desc")]
		public string ChangeDesc
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
	}
}
