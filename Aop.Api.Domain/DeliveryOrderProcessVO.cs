using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DeliveryOrderProcessVO : AopObject
	{
		[XmlElement("gmt_create")]
		public string GmtCreate
		{
			get;
			set;
		}

		[XmlElement("gmt_modified")]
		public string GmtModified
		{
			get;
			set;
		}

		[XmlElement("operate_info")]
		public string OperateInfo
		{
			get;
			set;
		}

		[XmlElement("operate_time")]
		public string OperateTime
		{
			get;
			set;
		}

		[XmlElement("operator_code")]
		public string OperatorCode
		{
			get;
			set;
		}

		[XmlElement("operator_name")]
		public string OperatorName
		{
			get;
			set;
		}

		[XmlElement("order_code")]
		public string OrderCode
		{
			get;
			set;
		}

		[XmlElement("order_id")]
		public string OrderId
		{
			get;
			set;
		}

		[XmlElement("order_type")]
		public string OrderType
		{
			get;
			set;
		}

		[XmlElement("process_status")]
		public string ProcessStatus
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
	}
}
