using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppCommonBillQueryModel : AopObject
	{
		[XmlElement("bill_no")]
		public string BillNo
		{
			get;
			set;
		}
	}
}
