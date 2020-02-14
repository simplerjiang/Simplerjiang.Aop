using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayDataDataserviceBillDownloadurlQueryModel : AopObject
	{
		[XmlElement("bill_date")]
		public string BillDate
		{
			get;
			set;
		}

		[XmlElement("bill_type")]
		public string BillType
		{
			get;
			set;
		}
	}
}
