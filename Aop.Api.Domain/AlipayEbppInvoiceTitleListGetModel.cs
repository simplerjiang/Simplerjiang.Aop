using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppInvoiceTitleListGetModel : AopObject
	{
		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
