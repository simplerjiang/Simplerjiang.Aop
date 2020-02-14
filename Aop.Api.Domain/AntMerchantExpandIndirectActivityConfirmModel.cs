using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AntMerchantExpandIndirectActivityConfirmModel : AopObject
	{
		[XmlElement("order_id")]
		public string OrderId
		{
			get;
			set;
		}
	}
}
