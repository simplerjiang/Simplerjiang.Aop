using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InvoiceTradeFundItem : AopObject
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("payment_tool_name")]
		public string PaymentToolName
		{
			get;
			set;
		}

		[XmlElement("payment_tool_type")]
		public string PaymentToolType
		{
			get;
			set;
		}
	}
}
