using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AntProdpaasProductCommonQueryResponse : AopResponse
	{
		[XmlElement("prod_base")]
		public ProductBaseVO ProdBase
		{
			get;
			set;
		}

		[XmlElement("prod_condition")]
		public string ProdCondition
		{
			get;
			set;
		}

		[XmlArray("prod_ip_list")]
		[XmlArrayItem("prod_i_p_relation_v_o")]
		public List<ProdIPRelationVO> ProdIpList
		{
			get;
			set;
		}

		[XmlArray("prod_lo_list")]
		[XmlArrayItem("prod_l_o_relation_v_o")]
		public List<ProdLORelationVO> ProdLoList
		{
			get;
			set;
		}

		[XmlArray("prod_mark_list")]
		[XmlArrayItem("prod_mark_relation_v_o")]
		public List<ProdMarkRelationVO> ProdMarkList
		{
			get;
			set;
		}

		[XmlArray("prod_rel_list")]
		[XmlArrayItem("prod_relation_v_o")]
		public List<ProdRelationVO> ProdRelList
		{
			get;
			set;
		}
	}
}
