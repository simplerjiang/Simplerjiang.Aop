using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFinanceFundFundnetvaluesBatchqueryResponse : AopResponse
	{
		[XmlElement("fund_code")]
		public string FundCode
		{
			get;
			set;
		}

		[XmlElement("fund_type")]
		public string FundType
		{
			get;
			set;
		}

		[XmlArray("net_values")]
		[XmlArrayItem("net_value_v_o")]
		public List<NetValueVO> NetValues
		{
			get;
			set;
		}
	}
}
