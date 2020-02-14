using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailWmsDeliveryorderprocessQueryModel : AopObject
	{
		[XmlElement("notice_order_id")]
		public string NoticeOrderId
		{
			get;
			set;
		}
	}
}
