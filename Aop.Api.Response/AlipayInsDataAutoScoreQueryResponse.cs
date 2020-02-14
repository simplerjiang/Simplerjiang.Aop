using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsDataAutoScoreQueryResponse : AopResponse
	{
		[XmlElement("bill_no")]
		public string BillNo
		{
			get;
			set;
		}

		[XmlElement("exclusive_score")]
		public string ExclusiveScore
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("score")]
		public long Score
		{
			get;
			set;
		}

		[XmlElement("uuid")]
		public string Uuid
		{
			get;
			set;
		}
	}
}
