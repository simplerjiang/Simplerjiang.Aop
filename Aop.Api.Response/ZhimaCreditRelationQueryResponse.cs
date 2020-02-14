using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCreditRelationQueryResponse : AopResponse
	{
		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("relation_info")]
		public RelationInfo RelationInfo
		{
			get;
			set;
		}

		[XmlElement("relation_rank")]
		public string RelationRank
		{
			get;
			set;
		}

		[XmlElement("relation_score")]
		public long RelationScore
		{
			get;
			set;
		}
	}
}
