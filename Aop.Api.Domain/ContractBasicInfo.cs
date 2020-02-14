using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ContractBasicInfo : AopObject
	{
		[XmlElement("brief_desc")]
		public string BriefDesc
		{
			get;
			set;
		}

		[XmlElement("contract_name")]
		public string ContractName
		{
			get;
			set;
		}

		[XmlElement("contract_no")]
		public string ContractNo
		{
			get;
			set;
		}

		[XmlElement("expire_time")]
		public string ExpireTime
		{
			get;
			set;
		}

		[XmlElement("last_promise_date")]
		public string LastPromiseDate
		{
			get;
			set;
		}

		[XmlElement("order")]
		public long Order
		{
			get;
			set;
		}

		[XmlElement("sign_time")]
		public string SignTime
		{
			get;
			set;
		}

		[XmlElement("source")]
		public string Source
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
