using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaCustomerContractRecordSyncModel : AopObject
	{
		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("biz_time")]
		public string BizTime
		{
			get;
			set;
		}

		[XmlElement("biz_type")]
		public string BizType
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

		[XmlElement("record_content")]
		public string RecordContent
		{
			get;
			set;
		}
	}
}
