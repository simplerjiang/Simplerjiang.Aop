using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class QueryDetailAopResult : AopObject
	{
		[XmlElement("batch_no")]
		public string BatchNo
		{
			get;
			set;
		}

		[XmlElement("detail_no")]
		public string DetailNo
		{
			get;
			set;
		}

		[XmlElement("ext_param")]
		public string ExtParam
		{
			get;
			set;
		}

		[XmlElement("fail_message")]
		public string FailMessage
		{
			get;
			set;
		}

		[XmlElement("last_modified")]
		public string LastModified
		{
			get;
			set;
		}

		[XmlElement("order_no")]
		public string OrderNo
		{
			get;
			set;
		}

		[XmlElement("pay_amount")]
		public string PayAmount
		{
			get;
			set;
		}

		[XmlElement("payee_id")]
		public string PayeeId
		{
			get;
			set;
		}

		[XmlElement("payer_id")]
		public string PayerId
		{
			get;
			set;
		}

		[XmlElement("service_charge")]
		public string ServiceCharge
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
