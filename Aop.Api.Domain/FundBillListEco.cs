using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FundBillListEco : AopObject
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("fund_channel")]
		public string FundChannel
		{
			get;
			set;
		}
	}
}
