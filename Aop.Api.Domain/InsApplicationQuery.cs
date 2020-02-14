using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsApplicationQuery : AopObject
	{
		[XmlElement("application_no")]
		public string ApplicationNo
		{
			get;
			set;
		}

		[XmlElement("application_status")]
		public string ApplicationStatus
		{
			get;
			set;
		}

		[XmlElement("merchant")]
		public InsMerchant Merchant
		{
			get;
			set;
		}

		[XmlElement("operation_id")]
		public string OperationId
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("prod_code")]
		public string ProdCode
		{
			get;
			set;
		}

		[XmlElement("trade_no")]
		public string TradeNo
		{
			get;
			set;
		}
	}
}
