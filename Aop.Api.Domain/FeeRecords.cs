using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FeeRecords : AopObject
	{
		[XmlElement("balance")]
		public string Balance
		{
			get;
			set;
		}

		[XmlElement("date")]
		public string Date
		{
			get;
			set;
		}

		[XmlElement("remark")]
		public string Remark
		{
			get;
			set;
		}

		[XmlElement("total_amount")]
		public string TotalAmount
		{
			get;
			set;
		}
	}
}
