using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class BatchDetailInfo : AopObject
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

		[XmlElement("message")]
		public string Message
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

		[XmlElement("pay_success_date")]
		public string PaySuccessDate
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

		[XmlElement("transfer_no")]
		public string TransferNo
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
