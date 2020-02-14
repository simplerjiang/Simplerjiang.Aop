using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySocialBaseRelationCombinedQueryResponse : AopResponse
	{
		[XmlArray("relation_combined_list")]
		[XmlArrayItem("relation_combined_v_o")]
		public List<RelationCombinedVO> RelationCombinedList
		{
			get;
			set;
		}
	}
}
