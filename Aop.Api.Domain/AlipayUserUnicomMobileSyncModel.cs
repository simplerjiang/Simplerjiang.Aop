using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserUnicomMobileSyncModel : AopObject
	{
		[XmlElement("gmt_status_change")]
		public long GmtStatusChange
		{
			get;
			set;
		}

		[XmlElement("mobile")]
		public string Mobile
		{
			get;
			set;
		}

		[XmlElement("operation_type")]
		public string OperationType
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

		[XmlElement("product_name")]
		public string ProductName
		{
			get;
			set;
		}
	}
}
