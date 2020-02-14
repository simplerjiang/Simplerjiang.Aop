using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppProdmodeTasknodeQueryResponse : AopResponse
	{
		[XmlElement("is_edit_all")]
		public string IsEditAll
		{
			get;
			set;
		}

		[XmlElement("is_edit_fund")]
		public string IsEditFund
		{
			get;
			set;
		}

		[XmlElement("node_code")]
		public string NodeCode
		{
			get;
			set;
		}

		[XmlElement("node_name")]
		public string NodeName
		{
			get;
			set;
		}

		[XmlElement("reject")]
		public string Reject
		{
			get;
			set;
		}

		[XmlElement("reject_time")]
		public string RejectTime
		{
			get;
			set;
		}
	}
}
