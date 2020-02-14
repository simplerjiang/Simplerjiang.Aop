using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SettleDetailInfo : AopObject
	{
		[XmlElement("amount")]
		public long Amount
		{
			get;
			set;
		}

		[XmlElement("summary_dimension")]
		public string SummaryDimension
		{
			get;
			set;
		}

		[XmlElement("trans_in")]
		public string TransIn
		{
			get;
			set;
		}

		[XmlElement("trans_in_type")]
		public string TransInType
		{
			get;
			set;
		}
	}
}
