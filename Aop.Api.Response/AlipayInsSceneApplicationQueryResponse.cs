using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsSceneApplicationQueryResponse : AopResponse
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

		[XmlArray("policys")]
		[XmlArrayItem("ins_policy")]
		public List<InsPolicy> Policys
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
