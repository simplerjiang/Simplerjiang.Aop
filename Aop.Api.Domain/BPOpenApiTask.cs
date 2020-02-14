using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class BPOpenApiTask : AopObject
	{
		[XmlElement("deal_url")]
		public string DealUrl
		{
			get;
			set;
		}

		[XmlElement("detail_url")]
		public string DetailUrl
		{
			get;
			set;
		}

		[XmlElement("display_name")]
		public string DisplayName
		{
			get;
			set;
		}

		[XmlElement("gmt_operate")]
		public string GmtOperate
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}

		[XmlElement("operate")]
		public string Operate
		{
			get;
			set;
		}

		[XmlElement("operate_transition")]
		public string OperateTransition
		{
			get;
			set;
		}

		[XmlElement("operator")]
		public string Operator
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

		[XmlElement("sign_type")]
		public string SignType
		{
			get;
			set;
		}

		[XmlElement("state")]
		public string State
		{
			get;
			set;
		}

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}
	}
}
