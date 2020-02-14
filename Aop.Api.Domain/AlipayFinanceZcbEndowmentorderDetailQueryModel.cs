using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayFinanceZcbEndowmentorderDetailQueryModel : AopObject
	{
		[XmlElement("end_time")]
		public string EndTime
		{
			get;
			set;
		}

		[XmlElement("product_id")]
		public string ProductId
		{
			get;
			set;
		}

		[XmlElement("start_time")]
		public string StartTime
		{
			get;
			set;
		}
	}
}
