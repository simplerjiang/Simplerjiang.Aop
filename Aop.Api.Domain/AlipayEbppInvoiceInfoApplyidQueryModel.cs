using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppInvoiceInfoApplyidQueryModel : AopObject
	{
		[XmlElement("apply_id")]
		public string ApplyId
		{
			get;
			set;
		}
	}
}
